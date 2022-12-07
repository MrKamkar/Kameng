namespace Kameng
{
    class Shape : Loader
    {
        public Vector position = new();

        public Shape(Size size) : base(size) { }

        public void DrawRectangle(Vector position, Size size, Color color)
        {
            for (int y = 0; y < size.height; y++)
            {
                char[] buffer = surface[position.y + y].ToCharArray();
                for (int x = 0; x < size.width; x++)
                {
                    buffer[position.x + x] = (char)color;
                }
                surface[position.y + y] = new string(buffer);
            }
        }

        public void DrawSquare(Vector position, int side, Color color)
        {
            DrawRectangle(position, new Size(side, side), color);
        }
    }
}