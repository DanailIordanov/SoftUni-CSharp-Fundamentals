using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var TrippleSumArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool Buffer = false;
            for (int i = 0; i < TrippleSumArray.Length; i++)
            {
                for (int j = i + 1; j < TrippleSumArray.Length; j++)
                {
                    int a = TrippleSumArray[i];
                    int b = TrippleSumArray[j];
                    int sum = a + b;
                    if (TrippleSumArray.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        Buffer = true;
                    }
                }
            }
            if (Buffer == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
