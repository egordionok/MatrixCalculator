namespace MatrixCalculator
{
    public struct Shape
    {
        public int X;
        public int Y;

        public Shape(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public static bool operator !=(Shape lhs, Shape rhs)
        {
            if (lhs.X != rhs.X || lhs.Y != rhs.Y) return true;
            return false;
        }
        public static bool operator ==(Shape lhs, Shape rhs)
        {
            if (lhs.X == rhs.X && lhs.Y == rhs.Y) return true;
            return false;
        }
    }
}
