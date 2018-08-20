using System;

namespace Engine.Managers
{
    public interface IRenderManager
    {
        event Action SwapBuffers;

        void Render(params IRenderable[] rederables);
    }
}