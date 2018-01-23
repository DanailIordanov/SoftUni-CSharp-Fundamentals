using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool prime = true;
                for (int start = 2; start <= Math.Sqrt(i); start++)
                {
                    if (i % start == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }

        }
    }
}
