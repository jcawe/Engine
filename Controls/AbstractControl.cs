using System;
using System.Collections.Generic;
using System.Linq;
using OpenTK.Input;

namespace Engine.Controls
{
    public abstract class AbstractControl<T> : IControl where T : struct, IConvertible
    {
        public abstract InputDeviceType DeviceType { get; }

        public ICollection<ITrigger> Triggers { get; } = new List<ITrigger>();

        public abstract void Update(IInputDevice input);

        protected void CheckButtons<TDevice>(TDevice device, Func<TDevice, T, bool> check)
            where TDevice : IInputDevice
        {
            foreach (var button in GetValues())
                if (check(device, button)) Triggers.ToList().ForEach(t => t.CheckTrigger(Convert.ToInt32(button)));
        }

        private T[] GetValues() => (T[])Enum.GetValues(typeof(T));
    }
}