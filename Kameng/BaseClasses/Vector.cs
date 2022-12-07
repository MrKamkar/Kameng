namespace Kameng
{
    class Vector
    {
        public int x, y;

        readonly public static Vector Zero = new Vector();

        public Vector(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector operator +(Vector first, Vector second)
        {
            return new Vector(first.x + second.x, first.y + second.y);
        }

        public static Vector operator -(Vector first, Vector second)
        {
            return new Vector(first.x - second.x, first.y - second.y);
        }
    }
}
