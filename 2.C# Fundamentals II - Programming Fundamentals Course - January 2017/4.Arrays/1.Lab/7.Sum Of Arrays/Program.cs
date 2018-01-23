using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sum_Of_Arrays
{
    public class Program
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < Math.Max(firstArray.Length, secondArray.Length); i++)
            {
                
                var ArraySum = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
                Console.Write(ArraySum + " ");
            }
        }
    }
}
