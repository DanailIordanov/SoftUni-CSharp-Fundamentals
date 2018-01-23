using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ", NumbersInRange(startNumber, endNumber)));
        }
        public static List<int> NumbersInRange(int startNumber, int endNumber)
        {
            var numbersInRange = new List<int>();
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    numbersInRange.Add(i);
                }
            }
            return numbersInRange;
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
