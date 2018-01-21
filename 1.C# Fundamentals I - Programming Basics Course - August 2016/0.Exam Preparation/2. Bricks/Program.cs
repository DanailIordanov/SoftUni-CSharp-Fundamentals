using System;

namespace _2.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());

            double kursove = x / (w * m);
            Console.WriteLine(Math.Ceiling(kursove));
        }
    }
}
