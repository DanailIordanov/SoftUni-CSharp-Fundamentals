using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = double.Parse(Console.ReadLine());
            var F = C * 1.8000 + 32.00;
            Math.Round(F, 2);
            Console.WriteLine(F);
        }
    }
}
