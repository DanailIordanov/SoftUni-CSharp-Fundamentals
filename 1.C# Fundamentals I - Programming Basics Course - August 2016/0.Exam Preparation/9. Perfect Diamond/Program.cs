using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int r = n - 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', r));
                Console.Write("*");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine(" ");
                r--;
            }
            int z = 1;
            for (int i = n - 1; i > 0; i--)
            {
                Console.Write(new string(' ', z));
                Console.Write("*");
                for (int j = i - 1; j > 0; j--)
                {
                    Console.Write("-*");
                }
                Console.WriteLine(" ");
                z++;
            }

        }
    }
}
