using System;
using System.Collections.Generic;
using Engine.Entities;

namespace Engine.Systems
{
    public class RenderSystem : IRenderSystem
    {
        //TODO: Filter of RenderSystem
        public Func<Entity, bool> Filter => throw new NotImplementedException();

        public void Render(IEnumerable<Entity> entities)
        {
            //TODO: Implement Render of RenderSystem
            throw new NotImplementedException();
        }
    }
}