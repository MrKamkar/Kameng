namespace Kameng
{
    enum Color
    {
        Black = '0',
        DarkBlue = '1',
        DarkGreen = '2',
        DarkRed = '3',
        DarkMagenta = '4',
        DarkYellow = '5',
        Gray = '6',
        DarkGray = '7',
        Blue = '8',
        Green = 'A',
        Cyan = 'B',
        Red = 'C',
        Magenta = 'D',
        Yellow = 'E',
        White = 'F'
    }

    struct Colors
    {
        public static ConsoleColor GetColor(Color color)
        {
            if (!int.TryParse(((char)color).ToString(), out int result)) result = (int)(char)color - (int)'A' + 10;
            return (ConsoleColor)result;
        }
    }
}
