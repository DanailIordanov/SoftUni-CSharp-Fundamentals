using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            for (int i = d; i <= e; i++)
            {
                    Console.Write($"{(char)i} ");
            }
        }
    }
}
