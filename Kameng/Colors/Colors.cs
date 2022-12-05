using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kameng.Colors
{
    struct Colors
    {
        public const char Black = '0';
        public const char DarkBlue = '1';
        public const char DarkGreen = '2';
        public const char DarkRed = '3';
        public const char DarkMagenta = '4';
        public const char DarkYellow = '5';
        public const char Gray = '6';
        public const char DarkGray = '7';
        public const char Blue = '8';
        public const char Green = 'A';
        public const char Cyan = 'B';
        public const char Red = 'C';
        public const char Magenta = 'D';
        public const char Yellow = 'E';
        public const char White = 'F';

        public static ConsoleColor GetColor(char type)
        {
            switch (type)
            {
                case Black:
                default:
                    return ConsoleColor.Black;
                case DarkBlue:
                    return ConsoleColor.DarkBlue;
                case DarkGreen:
                    return ConsoleColor.DarkGreen;
                case DarkRed:
                    return ConsoleColor.DarkRed;
                case DarkMagenta:
                    return ConsoleColor.DarkMagenta;
                case DarkYellow:
                    return ConsoleColor.DarkYellow;
                case Gray:
                    return ConsoleColor.Gray;
                case DarkGray:
                    return ConsoleColor.DarkGray;
                case Blue:
                    return ConsoleColor.Blue;
                case Green:
                    return ConsoleColor.Green;
                case Cyan:
                    return ConsoleColor.Cyan;
                case Red:
                    return ConsoleColor.Red;
                case Magenta:
                    return ConsoleColor.Magenta;
                case Yellow:
                    return ConsoleColor.Yellow;
                case White:
                    return ConsoleColor.White;
            }
        }
    }
}
