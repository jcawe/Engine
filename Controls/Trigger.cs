using System;

namespace Engine.Controls
{
    public class Trigger<T> : ITrigger where T : struct, IConvertible
    {
        readonly T _input;
        readonly Action _action;

        public Trigger(T input, Action action)
        {
            _input = input;
            _action = action;
        }

        public void CheckTrigger(int input)
        {
            if(Convert.ToInt32(_input) == input) _action?.Invoke();
        }
    }
}