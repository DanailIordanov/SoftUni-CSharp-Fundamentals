using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + currentNumber;
            }

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumRight = sumRight + currentNumber;
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"yes sum, {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }
        }
    }
}
