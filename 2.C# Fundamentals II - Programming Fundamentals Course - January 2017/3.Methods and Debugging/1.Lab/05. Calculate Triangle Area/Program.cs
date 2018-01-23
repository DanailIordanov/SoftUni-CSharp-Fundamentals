using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Triangle_Area
{
    public class Program
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetTriangleArea(width, height));
        }
        public static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
