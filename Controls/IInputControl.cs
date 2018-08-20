using OpenTK.Input;

namespace Engine.Controls
{
    public interface IInputControl
    {
        InputDeviceType DeviceType { get; }
        bool CheckInput(int input);
    }
}