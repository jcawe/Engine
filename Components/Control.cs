using System;
using System.Collections.Generic;
using Engine.Components;
using Engine.Controls;
using OpenTK.Input;

namespace Engine.Components
{
    public class Control : IComponent
    {
        public ICollection<ITrigger> Triggers { get; }
        public InputDeviceType DeviceType { get; }
    }
}