using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
        public static void PrintTriangle(int n)
        {
            for (int rows = 1; rows <= n; rows++)
            {
                PrintColumns(rows);
            }
            for (int rows = n - 1; rows > 0 ; rows--)
            {
                PrintColumns(rows);
            }
        }
        public static void PrintColumns(int rows)
        {
            for (int cols = 1; cols <= rows; cols++)
            {
                Console.Write($"{cols} ");
            }
            Console.WriteLine();
        }
    }
}
