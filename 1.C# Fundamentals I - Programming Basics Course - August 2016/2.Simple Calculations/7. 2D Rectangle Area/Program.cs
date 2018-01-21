using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var a = Math.Max(y1, y2) - Math.Min(y1, y2);
            var b = Math.Max(x1, x2) - Math.Min(x1, x2);

            var area = a * b;
            var perimeter = (a + b) * 2;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
