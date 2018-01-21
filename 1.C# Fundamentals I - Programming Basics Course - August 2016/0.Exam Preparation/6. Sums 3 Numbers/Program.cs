using System;

namespace _6.Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                int newA = Math.Min(a, b);
                int newB = Math.Max(a, b);
                Console.WriteLine($"{newA}+{newB}={c}");
            }
            else if (a + c == b)
            {
                int newA = Math.Min(a, c);
                int newC = Math.Max(a, c);
                Console.WriteLine($"{newA}+{newC}={b}");
            }
            else if (b + c == a)
            {
                int newb = Math.Min(b, c);
                int newc = Math.Max(b, c);
                Console.WriteLine($"{newb}+{newc}={a}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
