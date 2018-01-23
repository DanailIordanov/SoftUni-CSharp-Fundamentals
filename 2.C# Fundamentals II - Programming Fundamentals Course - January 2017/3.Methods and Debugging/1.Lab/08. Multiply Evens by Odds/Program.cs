using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_by_Odds
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }
        public static int GetMultipleOfEvensAndOdds(int number)
        {
            return Math.Abs(GetSumOfEvenDigits(number) * GetSumOfOddDigits(number));
        }

       public static int GetSumOfOddDigits(int number)
        {
            return GetSumofDigits(number, 1);   
        }

        public static int GetSumOfEvenDigits(int number)
        {
            return GetSumofDigits(number, 0);
        }

        public static int GetSumofDigits(int number, int remainder)
        {
            var result = 0;
            foreach (char symbol in number.ToString())
            {
                int digit = symbol - '0';
                if (digit % 2 == remainder)
                {
                    result += digit;
                }
            }
            return result;
        }
    }
}
