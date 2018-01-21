using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int y = n;

            if (y % 2 == 0)
            {
                y--;
            }

            Console.WriteLine(new string('%', n * 2));
            for (int row = 0; row < y; row++)
            {
                if (y / 2 == row)
                {
                    Console.WriteLine($"%{new string(' ', (n - 2))}**{new string(' ', (n - 2))}%");
                }
                else
                {
                    Console.WriteLine($"%{new string(' ', (n * 2) - 2)}%");
                }
            }
            Console.WriteLine(new string('%', n * 2));
        }
    }
}
