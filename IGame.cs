using System;
using Engine.Controls;

namespace Engine
{
    public interface IGame : IDisposable
    {
        //TODO: Remove Width and Height from here
        int Width { get; }
        int Height { get; }
        void Run();
        void AddControl(params IControl[] controls);
        void AddActor(params IActor[] actors);
        void AddRederable(params IRenderable[] rederables);
    }
}