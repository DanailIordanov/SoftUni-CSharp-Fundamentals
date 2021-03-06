﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
                PrintMiddleRow(n);
            PrintHeaderRow(n);
        }
        public static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new
              string('-', 2 * n));
        }
        public static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
                Console.Write("\\/");
            Console.WriteLine('-');
        }
    }
}
