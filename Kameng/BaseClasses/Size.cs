using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng
{
    public class Size
    {
        public int width { get; }
        public int height { get; }

        public Size(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size operator +(Size first, Size second)
        {
            return new Size(first.width + second.width, first.height + second.height);
        }

        public static Size operator -(Size first, Size second)
        {
            return new Size(first.width - second.width, first.height - second.height);
        }
    }
}
