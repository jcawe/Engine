using System.Linq;
using Engine.Controls;
using OpenTK.Input;

namespace Engine.Managers
{
    public class ControlManager : IControlManager
    {
        public void Update(IControl[] controls, params IInputDevice[] devices)
        {
            foreach(var control in controls)
            {
                var device = devices.FirstOrDefault(x => x.DeviceType == control.DeviceType);
                if(device != null) control.Update(device);
            }
        }
    }
}