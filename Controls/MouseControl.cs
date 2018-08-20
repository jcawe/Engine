using OpenTK.Input;

namespace Engine.Controls
{
    public class MouseControl : IInputControl
    {
        public InputDeviceType DeviceType => InputDeviceType.Mouse;

        public bool CheckInput(int input) =>
            Mouse.GetState().IsButtonDown((MouseButton)input);
    }
}