using System;
using System.Collections.Generic;
using Engine.Entities;

namespace Engine.Systems
{
    public interface IRenderSystem : ISystem
    {
        Func<Entity, bool> Filter { get; }
         void Render(IEnumerable<Entity> entities);
    }
}