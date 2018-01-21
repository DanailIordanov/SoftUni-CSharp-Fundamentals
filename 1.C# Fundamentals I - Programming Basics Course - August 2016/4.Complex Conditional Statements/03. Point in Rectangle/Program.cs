using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var maxX = Math.Max(x1, x2);
            var minX = Math.Min(x1, x2);
            var maxY = Math.Max(y1, y2);
            var minY = Math.Min(y1, y2);
            if (x >= minX && x <= maxX && y <= minY && y >= maxY)
                Console.WriteLine("Inside");
            else
                Console.WriteLine("Outside");

        }
    }
}
