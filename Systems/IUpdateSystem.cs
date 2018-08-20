using System;
using System.Collections.Generic;
using Engine.Entities;

namespace Engine.Systems
{
    public interface IUpdateSystem : ISystem
    {
        Func<Entity, bool> Filter { get; }
         void Update(IEnumerable<Entity> entities);
    }
}