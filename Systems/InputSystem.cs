using System;
using System.Collections.Generic;
using System.Linq;
using Engine.Components;
using Engine.Controls;
using Engine.Entities;
using OpenTK.Input;

namespace Engine.Systems
{
    public class InputSystem : IUpdateSystem
    {
        readonly List<IInputControl> _inputs;

        public Func<Entity, bool> Filter => e => e.HasComponent<Control>();

        public InputSystem(params IInputControl[] inputs) =>
            _inputs = _inputs.ToList() ?? throw new ArgumentNullException(nameof(inputs));

        public void Update(IEnumerable<Entity> entities)
        {
            var components = entities.SelectMany(x => x.GetComponents<Control>());

            foreach (var input in _inputs)
                foreach (var control in components.Where(c => c.DeviceType == input.DeviceType))
                    foreach (var trigger in control.Triggers)
                        if (input.CheckInput(trigger.InputTrigger)) trigger.Action();
        }
    }
}