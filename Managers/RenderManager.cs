using System;
using OpenTK.Graphics.OpenGL;

namespace Engine.Managers
{
    public class RenderManager : IRenderManager
    {
        public event Action SwapBuffers;

        public void Render(params IRenderable[] rederables)
        {
            GL.ClearColor(0,0,0,0);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            foreach(var renderable in rederables)
            {
                renderable.Render();
            }

            SwapBuffers?.Invoke();
        }        
    }
}