using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (var row = 1; row <= n; row++)
            {
                for (var col = 1; col <= n - row; col++)
                    Console.Write(" ");
                Console.Write("*");
                for (var col = 1; col < row; col++)
                    Console.Write(" *");
                Console.WriteLine();
            }
            for (int row = n - 1; row >= 1; row--)
            {
                for (var col = 1; col <= n - row; col++)
                    Console.Write(" ");
                Console.Write("*");
                for (var col = 1; col < row; col++)
                    Console.Write(" *");
                Console.WriteLine();
            }
        }
    }
}
