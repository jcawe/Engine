using System.Collections.Generic;
using OpenTK;

namespace Engine.Components
{
    public class Text : IComponent
    {
        public string Value { get; set; }
        public Dictionary<char, Sprite> Font { get; set; }
    }
}