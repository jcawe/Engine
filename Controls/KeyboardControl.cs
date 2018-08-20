using System.Collections.Generic;
using OpenTK.Input;

namespace Engine.Controls
{
    public class KeyboardControl : IInputControl
    {
        public InputDeviceType DeviceType => InputDeviceType.Keyboard;

        public bool CheckInput(int input) =>
            Keyboard.GetState().IsKeyDown((Key)input);
    }
}