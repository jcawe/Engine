using OpenTK;

namespace Engine.Managers
{
    public interface IDrawingManager
    {
        Size ScreenSize { get; }

        /// <summary>
        /// Draws a rectangle with the top left corner at 
        /// position, with size and color indicates
        /// </summary>
        /// <param name="color">Background color of the rectangle</param>
        /// <param name="position">Position of the top left corner</param>
        /// <param name="size">Size of rectangle</param>
        /// <param name="isEmpty">Border only rectangle</param>
        void DrawRectangle(Color color, Vector2 position, Size size, bool isEmpty = false);

        /// <summary>
        /// Draws a fullscreen rectangle with the 
        /// color indicate
        /// </summary>
        /// <param name="color">Background color of the rectangle</param>
        /// <param name="isEmpty">Border only rectangle</param>
        void DrawRectangle(Color color, bool isEmpty = false);
    }
}