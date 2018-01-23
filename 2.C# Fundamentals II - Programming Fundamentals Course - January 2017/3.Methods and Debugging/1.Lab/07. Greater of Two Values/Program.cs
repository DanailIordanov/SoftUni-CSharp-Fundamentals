using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    public class Program
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b)); 
            }
            else
            {
                Console.WriteLine(GetMax(Console.ReadLine(), Console.ReadLine())); 
            }
            
        }
        public static int GetMax(int a, int b)
        {
            return Math.Max(a,b);
        }
        public static char GetMax(char a, char b)
        {
            return (char)GetMax((int) a, b);
        }
        public static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) < 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}
