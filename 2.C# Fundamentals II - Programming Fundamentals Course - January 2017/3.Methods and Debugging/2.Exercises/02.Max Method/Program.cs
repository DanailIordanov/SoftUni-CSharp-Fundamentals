using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a, b, c));
        }
        public static int GetMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}
