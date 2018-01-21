using System;

namespace _1.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int h = Math.Abs(y1 - y2);
            int a = Math.Abs(x2 - x3);

            double S = (a * h) / 2d;
            Console.WriteLine(S);
        }
    }
}
