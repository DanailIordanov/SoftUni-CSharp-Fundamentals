using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            ////
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double s = a * a;
                Console.WriteLine($"{s:F3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double s = a * b;
                Console.WriteLine($"{s:F3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double s = Math.PI * r * r;
                Console.WriteLine($"{s:F3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double s = a * h / 2;
                Console.WriteLine($"{s:F3}");
            }
        }
    }
}
