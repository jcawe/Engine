using System;
using System.Collections.Generic;
using OpenTK.Input;

namespace Engine.Controls
{
    public interface IControl
    {
        ICollection<ITrigger> Triggers { get; }
        InputDeviceType DeviceType { get; }
        void Update(IInputDevice input);
    }
}