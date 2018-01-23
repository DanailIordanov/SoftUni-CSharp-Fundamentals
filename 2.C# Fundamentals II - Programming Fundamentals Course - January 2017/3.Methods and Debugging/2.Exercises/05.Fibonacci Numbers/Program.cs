using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
        public static int Fibonacci(int n)
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }
            return sum;
        }
    }
}
