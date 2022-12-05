using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng.Kameng
{
    class Loader : Surface
    {
        public Loader(int width, int height) : base(width, height) {}

        public bool Load(string path, int frame)
        {
            string[] allLines = System.IO.File.ReadAllLines(path);

            if(allLines.Length < height * frame) return false;

            for (int a = 0; a < height; a++)
            {
                for (int b = 0; b < width; b++)
                {
                    surface[a].ToCharArray()[b] = allLines[height * frame + a][b];
                }
            }
            return true;
        }
    }
}
