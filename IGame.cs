using System;
using Engine.Controls;

namespace Engine
{
    public interface IGame : IDisposable
    {
        void Run();
    }
}