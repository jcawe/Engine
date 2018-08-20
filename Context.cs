using System.Collections.Generic;
using Engine.Entities;
using Engine.Systems;

namespace Engine
{
    public class Context
    {
        public List<Entity> Entities { get; } = new List<Entity>();

        public List<ISystem> Systems { get; } = new List<ISystem>();
    }
}