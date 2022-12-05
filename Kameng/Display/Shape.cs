using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng.Display
{
    class Shape : Loader
    {
        public Vector position = new Vector();

        public Shape(int width, int height) : base(width, height) { }

        public void DrawRectangle(Vector position, int width, int height, char color)
        {
            for (int a = 0; a < height; a++)
            {
                char[] buffer = surface[position.y + a].ToCharArray();
                for (int b = 0; b < width; b++)
                {
                    buffer[position.x + b] = color;
                }
                surface[position.y + a] = new string(buffer);
            }
        }

        public void DrawSquare(Vector position, int side, char color)
        {
            DrawRectangle(position, side, side, color);
        }
    }
}
