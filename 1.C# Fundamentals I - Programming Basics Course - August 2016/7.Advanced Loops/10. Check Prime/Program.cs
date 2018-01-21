using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            var prime = true;
            for (var i = 2; i <= n; i++)
                if (n % i == 0 || n == 0 || n == 1)
                {
                    prime = false;
                    break;
                }
            if (prime && n != 1 && n!= 0)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
