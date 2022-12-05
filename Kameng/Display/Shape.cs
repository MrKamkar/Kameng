using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng.Display
{
    class Shape : Loader
    {
        public int x = 0;
        public int y = 0;
        public Vector position { get { position = new Vector(x, y); return position; } set { x = position.x; y = position.y; } }

        public Shape(int width, int height) : base(width, height) { }

        public void DrawRectangle(int x, int y, int width, int height, char color)
        {
            for (int a = 0; a < height; a++)
            {
                char[] buffer = surface[y + a].ToCharArray();
                for (int b = 0; b < width; b++)
                {
                    buffer[x + b] = color;
                }
                surface[y + a] = new string(buffer);
            }
        }

        public void DrawSquare(int x, int y, int side, char color)
        {
            DrawRectangle(x, y, side, side, color);
        }
    }
}
