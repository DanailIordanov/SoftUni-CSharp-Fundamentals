using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    public class Program
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(number, power));
        }
        public static double RaiseToPower(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
