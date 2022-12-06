using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng
{
    class Canvas : Surface
    {
        public Canvas(Size size) : base(size) { }

        public void Fill(char color)
        {
            for (int y = 0; y < size.height; y++)
            {
                char[] buffer = surface[y].ToCharArray();
                for (int x = 0; x < size.width; x++)
                {
                    buffer[x] = color;
                }
                surface[y] = new string(buffer);
            }
        }

        public void Draw(Shape shape)
        {
            for (int y = 0; y < shape.size.height; y++)
            {
                char[] buffer = surface[shape.position.y + y].ToCharArray();
                for (int x = 0; x < shape.size.width; x++)
                {
                    if (shape.surface[y].ToCharArray()[x] != ' ') buffer[shape.position.x + x] = shape.surface[y].ToCharArray()[x];
                }
                surface[shape.position.y + y] = new string(buffer);
            }
        }

        public void Render()
        {
            for (int y = 0; y < size.height; y++)
            {
                for (int x = 0; x < size.width; x++)
                {
                    Console.BackgroundColor = Colors.GetColor(surface[y].ToCharArray()[x]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
