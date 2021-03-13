using System;
using System.Drawing;

namespace WhereMyAnagramsAt
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0, 0);
            Point b = new Point(10, 10);

            DistanceBetweenPoints(a, b);
        }
        public static double DistanceBetweenPoints(Point a, Point b)
        {
            return Math.Abs(Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)));
        }
    }
}
