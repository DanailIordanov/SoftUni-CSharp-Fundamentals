using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    public class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(n);
            Console.WriteLine(isPrime);
        }
        public static bool IsPrime(long n)
        {
            bool isPrime = true;
            if (n == 1 || n == 0)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
