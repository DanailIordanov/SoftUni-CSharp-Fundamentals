using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double d = r * (180d / Math.PI);
            Console.WriteLine(Math.Round(d, 2));
        }
    }
}
