using System;

namespace Engine.Controls
{
    public interface ITrigger
    {
        int InputTrigger { get; }
        Action Action {get;}
    }
}