using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (int c1 = 1; c1 <= n - 2; c1++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            for (int row = 1; row <= n - 2; row++)
            {
                Console.Write("|");
                for (int c2 = 1; c2 <= n - 2; c2++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            Console.Write("+");
            for (int c3 = 1; c3 <= n - 2; c3++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
