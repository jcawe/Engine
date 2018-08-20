using OpenTK;

namespace Engine
{
    public class DrawScreen
    {
        private readonly Size _size;

        public DrawScreen(int width, int height) : this(new Size(width, height)) { }

        public DrawScreen(Size size)
        {
            _size = size;
        }

        public int Width => _size.Width;
        public int Height => _size.Height;

        public Size Size => _size;
    }
}