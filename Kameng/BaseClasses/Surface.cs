using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng
{
    class Surface
    {
        public Size size;
        public string[] surface;

        public void Clear()
        {
            for (int y = 0; y < size.height; y++)
            {
                string line = string.Empty;
                for (int x = 0; x < size.width; x++)
                {
                    line += ' ';
                }
                surface[y] = line;
            }
        }

        public Surface(Size size)
        {
            this.size = size;
            surface = new string[size.height];
            Clear();
        }
    }
}
