using System;

namespace Engine.Controls
{
    public class Trigger<T> : ITrigger where T : struct, IConvertible
    {
        readonly T _input;
        public Action Action { get; }

        public int InputTrigger => Convert.ToInt32(_input);

        public Trigger(T input, Action action)
        {
            _input = input;
            Action = action;
        }
    }
}