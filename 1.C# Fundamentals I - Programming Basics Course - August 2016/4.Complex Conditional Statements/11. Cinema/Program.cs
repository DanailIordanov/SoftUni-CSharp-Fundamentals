using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double income = 0.00;
            ////
            if (type == "Premiere")
            {
                income = rows * cols * 12.00;
            }
            if (type == "Normal")
            {
                income = rows * cols * 7.50;
            }
            if (type == "Discount")
            {
                income = rows * cols * 5.00;
            }

            Console.WriteLine($"{income:f2}");
        }
    }
}
