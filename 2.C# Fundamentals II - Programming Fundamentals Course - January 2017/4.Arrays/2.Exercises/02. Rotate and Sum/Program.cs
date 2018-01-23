using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var IntegersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int NumberOfRotations = int.Parse(Console.ReadLine());

            var sum = new int[IntegersArray.Length];
            for (int indexOfRotations = 0; indexOfRotations < NumberOfRotations; indexOfRotations++)
            {
                int lastNumber = IntegersArray[IntegersArray.Length - 1];
                for (int a = IntegersArray.Length - 1; a > 0; a--)
                {
                    IntegersArray[a] = IntegersArray[a - 1];
                }
                IntegersArray[0] = lastNumber;
                for (int b = 0; b < IntegersArray.Length; b++)
                {
                    sum[b] += IntegersArray[b];
                }
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
