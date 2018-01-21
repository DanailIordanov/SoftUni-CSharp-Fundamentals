using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (a + b) / 2 * h;
            Console.WriteLine(area);
        }
    }
}
