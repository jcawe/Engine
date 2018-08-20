using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Engine.Controls;
using Engine.Managers;
using Engine.Systems;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Engine
{
    public class Game : GameWindow, IGame
    {
        readonly Context _context;

        public Game(DrawScreen screen, string title, Context context) 
            : base(screen.Width, screen.Height, GraphicsMode.Default, title, GameWindowFlags.Default, DisplayDevice.Default, 4, 5, GraphicsContextFlags.ForwardCompatible)
        {
            _context = context;
            
            Load += Init;
            UpdateFrame += Update;
            RenderFrame += Render;
            Closing += Clean;
        }

        private void Init(object sender, EventArgs e)
        {
            foreach(var system in _context.Systems.OfType<IInitSystem>())
                system.Init();
        }

        private void Render(object sender, FrameEventArgs e)
        {
            GL.ClearColor(0,0,0,0);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            
            foreach(var system in _context.Systems.OfType<IRenderSystem>())
                system.Render(_context.Entities.Where(system.Filter));

            SwapBuffers();
        }

        private void Update(object sender, FrameEventArgs e)
        {
            foreach(var system in _context.Systems.OfType<IUpdateSystem>())
                system.Update(_context.Entities.Where(system.Filter));
        }

        private void Clean(object sender, CancelEventArgs e)
        {
            foreach(var system in _context.Systems.OfType<ICleanSystem>())
                system.Clean();
        }

        void IGame.Run() => Run(30.0);
    }
}