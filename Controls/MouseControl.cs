using OpenTK.Input;

namespace Engine.Controls
{
    public class MouseControl : AbstractControl<MouseButton>
    {
        public override InputDeviceType DeviceType => InputDeviceType.Mouse;

        public override void Update(IInputDevice input)
        {
            CheckButtons(input as MouseDevice, (m, b) => m[b]);
        }
    }
}