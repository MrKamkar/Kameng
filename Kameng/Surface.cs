using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng.Kameng
{
    class Surface
    {
        public int width { get; }
        public int height { get; }
        public string[] surface;

        public void Clear()
        {
            for (int a = 0; a < height; a++)
            {
                string line = String.Empty;
                for (int b = 0; b < width; b++)
                {
                    line += ' ';
                }
                surface[a] = line;
            }
        }

        public Surface(int width, int height)
        {
            this.width = width;
            this.height = height;
            surface = new string[height];
            Clear();
        }
    }
}
