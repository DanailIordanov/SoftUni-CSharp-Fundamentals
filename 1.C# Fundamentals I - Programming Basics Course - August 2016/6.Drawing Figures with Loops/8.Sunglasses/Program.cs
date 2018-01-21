using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

            for (int i = 0; i < n - 2; i++)
            {

                Console.Write("*");
                for (int r = 0; r < (n * 2) - 2; r++)
                {
                    Console.Write("/");
                }
                Console.Write("*");

                if (i == (n - 1) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.Write("*");
                for (int r = 0; r < (n * 2) - 2; r++)
                {
                    Console.Write("/");
                }
                Console.Write("*");

                Console.WriteLine();
            }


            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
