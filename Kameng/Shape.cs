﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng.Kameng
{
    class Shape : Loader
    {
        public int x = 0;
        public int y = 0;

        public Shape(int width, int height) : base(width, height) {}

        public void DrawRectangle(int x, int y, int width, int height, char color)
        {
            for(int a = 0; a < height; a++)
            {
                char[] buffer = surface[y + a].ToCharArray();
                for (int b = 0; b < width; b++)
                {
                    buffer[x + b] = color;
                }
                surface[y + a] = new String(buffer);
            }
        }

        public void DrawSquare(int x, int y, int side, char color)
        {
            DrawRectangle(x, y, side, side, color);
        }
    }
}
