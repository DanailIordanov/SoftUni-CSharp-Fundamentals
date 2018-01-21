using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (y == 0 || y == n - 1 || x == 0 || x == n - 1)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
