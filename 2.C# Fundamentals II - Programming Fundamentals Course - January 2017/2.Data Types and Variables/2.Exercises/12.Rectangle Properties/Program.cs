using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double p = 2 * (a + b);
            double s = a * b;
            double diagonal = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(diagonal);
        }
    }
}
