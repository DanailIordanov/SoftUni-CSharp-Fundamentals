using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());

            var InputNubmers = new long[n + 1];
            var checkNums = new bool[n + 1];

            string PrimeNums = " ";

            for (int i = 0; i <= n; i++)
            {
                InputNubmers[i] = i;
                checkNums[i] = true;
            }

            PrimeNums = SieveOfEratosthenes(InputNubmers, checkNums, PrimeNums, n);
            Console.WriteLine(PrimeNums.Trim());
        }

        public static string SieveOfEratosthenes(long[] InputNumbers, bool[] CheckNums, string PrimeNums, long n)
        {
            CheckNums[0] = CheckNums[1] = false;
            for (int i = 0; i < InputNumbers.Length; i++)
            {
                if (CheckNums[i])
                {
                    PrimeNums += $"{InputNumbers[i]} ";
                    for (int j = 2; j < InputNumbers.Length; j++)
                    {
                        if (j * i < InputNumbers.Length)
                        {
                            CheckNums[j * i] = false;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return PrimeNums;
        }
    }
}
