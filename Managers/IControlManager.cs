using System;
using Engine.Controls;
using OpenTK.Input;

namespace Engine.Managers
{
    public interface IControlManager
    {
         void Update(IControl[] controls, params IInputDevice[] devices);
    }
}