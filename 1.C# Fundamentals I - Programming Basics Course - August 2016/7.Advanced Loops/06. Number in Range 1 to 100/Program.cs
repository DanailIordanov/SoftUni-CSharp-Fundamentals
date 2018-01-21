using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {num}");
        }
    }
}
