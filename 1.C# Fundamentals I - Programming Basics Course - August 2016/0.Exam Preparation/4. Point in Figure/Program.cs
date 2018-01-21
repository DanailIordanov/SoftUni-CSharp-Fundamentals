using System;

namespace _4.Point_in_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x >= 4 && x <= 10 && y <= 3 && y >= -5)
            {
                Console.WriteLine("in");
            }
            else if (x >= 2 && x <= 12 && y >= -3 && y <= 1)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
