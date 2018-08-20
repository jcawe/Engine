using System.Collections.Generic;
using System.Linq;
using Engine.Components;

namespace Engine.Entities
{
    public class Entity
    {
        List<IComponent> _components;

        public Entity(params IComponent[] components) => 
            _components = components?.ToList();

        public void AddComponents(params IComponent[] components) => 
            _components.AddRange(components);
        
        public void RemoveComponents(params IComponent[] components)
        {
            foreach(var component in components)
                _components.Remove(component);
        }

        public IEnumerable<T> GetComponents<T>() where T : IComponent =>
            _components.OfType<T>();

        public bool HasComponent<T>() where T : IComponent =>
            _components.Any(x => x.GetType() == typeof(T));
    }
}