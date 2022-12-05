using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng
{
    class Vector
    {
        public int x, y;

        public Vector(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector operator + (Vector first, Vector second)
        {
            return new Vector(first.x + second.x, first.y + second.y);
        }

        public static Vector operator - (Vector first, Vector second)
        {
            return new Vector(first.x - second.x, first.y - second.y);
        }
    }
}
