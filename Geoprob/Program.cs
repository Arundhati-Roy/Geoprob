using System;

namespace Geoprob
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3, x2 = 6;
            int y1 = 4, y2 = 9;
            double length = 0;

            length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Length of the line is " + length);
        }
    }
}
