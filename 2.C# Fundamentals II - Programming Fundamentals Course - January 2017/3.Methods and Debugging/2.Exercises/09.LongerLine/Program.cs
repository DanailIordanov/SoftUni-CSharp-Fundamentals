using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    public class Program
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double LineA = LineLength(x1, y1, x2, y2);
            double LineB = LineLength(x3, y3, x4, y4);

            if (LineA > LineB)
            {
                Console.WriteLine($"({string.Join( ", ", CloserPoint(x1, y1, x2, y2))})({string.Join(", ", FarPoint(x1, y1, x2, y2))})");
            }
            else
            {
                Console.WriteLine($"({string.Join(", ", CloserPoint(x3, y3, x4, y4))})({string.Join(", ", FarPoint(x3, y3, x4, y4))})");
            }
        }
        public static double LineLength(double x1, double y1, double x2, double y2)
        {
            double lineLength = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return lineLength;
        }
        public static List<double> CloserPoint(double x1, double y1, double x2, double y2)
        {
            var closerCoordinates = new List<double>();
            if (Math.Sqrt(x1 * x1) + Math.Sqrt(y1 * y1) < Math.Sqrt(x2 * x2) + Math.Sqrt(y2 * y2))
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
        public static List<double> FarPoint(double x1, double y1, double x2, double y2)
        {
            var closerCoordinates = new List<double>();
            if (Math.Sqrt(x1 * x1) + Math.Sqrt(y1 * y1) >= Math.Sqrt(x2 * x2) + Math.Sqrt(y2 * y2))
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
