using System;

namespace GeoAssg1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3, x2 = 6;
            int y1 = 4, y2 = 9;

            int x3 = 5, x4 = 10;
            int y3 = 8, y4 = 12;
            double length1 = 0, lenght2 = 0;

            length1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            lenght2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            if (lenght2.Equals(length1))
            {
                Console.WriteLine("Both lines are of equal length");
            }
            else
            {
                Console.WriteLine("Both lines are of different length");
            }
        }
    }
}