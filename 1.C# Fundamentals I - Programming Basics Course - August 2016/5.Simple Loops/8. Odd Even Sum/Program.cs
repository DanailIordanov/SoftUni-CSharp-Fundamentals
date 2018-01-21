using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }

            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum={sumEven}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff={Math.Abs(sumEven - sumOdd)}");
            }
        }
    }
}
