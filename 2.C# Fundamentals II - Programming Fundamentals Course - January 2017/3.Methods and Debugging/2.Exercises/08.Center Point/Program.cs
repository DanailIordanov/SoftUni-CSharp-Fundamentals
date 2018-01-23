using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"({string.Join(", ", CloserPoint(x1, y1, x2, y2))})");
        }
        public static List<double> CloserPoint (double x1, double y1, double x2, double y2)
        {
            var closerCoordinates = new List<double>();
            if (Math.Sqrt(x1*x1) + Math.Sqrt(y1*y1) < Math.Sqrt(x2*x2) + Math.Sqrt(y2*y2))
            {
                closerCoordinates.Add(x1);
                closerCoordinates.Add(y1);
            }
            else
            {
                closerCoordinates.Add(x2);
                closerCoordinates.Add(y2);
            }
            return closerCoordinates;
        }
    }
}
