using System;
using System.Collections.Generic;
using Engine.Controls;
using Engine.Managers;
using OpenTK;
using OpenTK.Graphics;

namespace Engine
{
    public class Game : GameWindow, IGame
    {
        readonly IRenderManager _renderManager;
        readonly IControlManager _controlManager;
        readonly IActorManager _actorManager;

        readonly List<IActor> _actors = new List<IActor>();
        readonly List<IRenderable> _renderables = new List<IRenderable>();
        readonly List<IControl> _controls = new List<IControl>();

        int IGame.Width => ClientRectangle.Width;
        int IGame.Height => ClientRectangle.Height;
        
        public Game(DrawScreen screen, string title, IRenderManager render, IControlManager control, IActorManager actorManager) 
            : base(screen.Width, screen.Height, GraphicsMode.Default, title, GameWindowFlags.Default, DisplayDevice.Default, 4, 5, GraphicsContextFlags.ForwardCompatible)
        {
            _renderManager = render ?? throw new ArgumentNullException(nameof(render));
            _controlManager = control ?? throw new ArgumentNullException(nameof(control));
            _actorManager = actorManager ?? throw new ArgumentNullException(nameof(actorManager));
            
            UpdateFrame += Update;
            RenderFrame += Render;
            _renderManager.SwapBuffers += SwapBuffers;
        }

        private void Render(object sender, FrameEventArgs e)
        {
            _renderManager.Render(_renderables.ToArray());
        }

        private void Update(object sender, FrameEventArgs e)
        {
            _controlManager.Update(_controls.ToArray(), Keyboard, Mouse);
            _actorManager.Update(_actors.ToArray());
        }

        void IGame.Run() => Run(30.0);

        public void AddControl(params IControl[] controls) => _controls.AddRange(controls);

        public void AddActor(params IActor[] actors) => _actors.AddRange(actors);

        public void AddRederable(params IRenderable[] renderables) => _renderables.AddRange(renderables);
    }
}