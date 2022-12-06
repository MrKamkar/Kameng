using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng
{
    class Loader : Surface
    {
        public Loader(Size size) : base(size) { }

        public bool Load(string path, int frame)
        {
            string[] allLines = System.IO.File.ReadAllLines(path);

            if (allLines.Length < size.height * frame) return false;

            for (int y = 0; y < size.height; y++)
            {
                for (int x = 0; x < size.width; x++)
                {
                    surface[y].ToCharArray()[x] = allLines[size.height * frame + y][x];
                }
            }
            return true;
        }
    }
}
