using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(GetDigit(number));

        }
        public static string GetDigit(long number)
        {
            string digit = "0";
            foreach (char symbol in number.ToString())
            {
                digit = symbol.ToString();
            }
            switch (digit)
            {
                case "1": return "one";
                case "2": return "two";
                case "3": return "three";
                case "4": return "four";
                case "5": return "five";
                case "6": return "six";
                case "7": return "seven";
                case "8": return "eight";
                case "9": return "nine";
                default: return "zero";
            }
        }
    }
}
