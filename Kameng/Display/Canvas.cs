using Kameng;
using Kameng.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng.Display
{
    class Canvas : Surface
    {
        public Canvas(int width, int height) : base(width, height) { }

        public void Fill(char color)
        {
            for (int a = 0; a < height; a++)
            {
                char[] buffer = surface[a].ToCharArray();
                for (int b = 0; b < width; b++)
                {
                    buffer[b] = color;
                }
                surface[a] = new string(buffer);
            }
        }

        public void Draw(Shape shape)
        {
            for (int a = 0; a < shape.height; a++)
            {
                char[] buffer = surface[shape.y + a].ToCharArray();
                for (int b = 0; b < shape.width; b++)
                {
                    if (shape.surface[a].ToCharArray()[b] != ' ') buffer[shape.x + b] = shape.surface[a].ToCharArray()[b];
                }
                surface[shape.y + a] = new string(buffer);
            }
        }

        public void Render()
        {
            for (int a = 0; a < height; a++)
            {
                for (int b = 0; b < width; b++)
                {
                    Console.BackgroundColor = Kameng.Colors.Colors.GetColor(surface[a].ToCharArray()[b]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
