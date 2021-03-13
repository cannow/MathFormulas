using System;
using System.Drawing;

namespace MathFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0, 0);
            Point b = new Point(10, 10);

            int[] volumeA = {1, 2, 3};
            int[] volumeB = {4, 5, 6};

            DistanceBetweenPoints(a, b);
            FindDifference_Volume(volumeA, volumeB);
        }
        public static double DistanceBetweenPoints(Point a, Point b)
        {
            //Console.WriteLine(Math.Abs(Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2))));
            return Math.Abs(Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)));
        }
        
        public static int FindDifference_Volume(int[] a, int[] b)
        {
            //Console.WriteLine(Math.Abs((a[0] * a[1] * a[2]) - (b[0] * b[1] * b[2])));
            return Math.Abs((a[0] * a[1] * a[2]) - (b[0] * b[1] * b[2]));
        }
    }
}
