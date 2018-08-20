using System.Collections.Generic;
using OpenTK.Input;

namespace Engine.Controls
{
    public class KeyboardControl : AbstractControl<Key>
    {
        public override InputDeviceType DeviceType => InputDeviceType.Keyboard;

        public override void Update(IInputDevice input)
        {
            CheckButtons(input as KeyboardDevice, (k, b) => k[b]);
        }
    }
}