using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
