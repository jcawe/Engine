using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Engine.Managers
{
    public class DrawingManager : IDrawingManager
    {
        private readonly DrawScreen _screen;

        public Size ScreenSize => _screen.Size;

        public DrawingManager(DrawScreen screen) => _screen = screen;

        public void DrawRectangle(Color color, Vector2 position, Size size, bool isEmpty = false)
        {
            var x0 = ConvertXToWorld(position.X);
            var x1 = ConvertXToWorld(position.X + size.Width);
            var y0 = ConvertYToWorld(position.Y);
            var y1 = ConvertYToWorld(position.Y + size.Height);

            GL.Begin(isEmpty ? PrimitiveType.LineLoop : PrimitiveType.Quads);

            GL.Color3(color);
            GL.Vertex2(x0, y0);
            GL.Vertex2(x1, y0);
            GL.Vertex2(x1, y1);
            GL.Vertex2(x0, y1);

            GL.End();
        }

        public void DrawRectangle(Color color, bool isEmpty = false) =>
            DrawRectangle(color, Vector2.Zero, _screen.Size, isEmpty);

        private float ConvertXToWorld(float x) => ((4f * x / _screen.Width) - 2f) / 2f;
        private float ConvertYToWorld(float y) => ((4f * (-y) / _screen.Height) + 2f) / 2f;
    }
}