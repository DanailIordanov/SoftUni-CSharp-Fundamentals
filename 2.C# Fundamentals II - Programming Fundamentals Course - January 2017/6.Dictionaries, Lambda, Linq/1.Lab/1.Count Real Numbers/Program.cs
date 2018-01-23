namespace _1.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse);

            var numbersCount = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersCount.ContainsKey(number))
                {
                    numbersCount[number] = 0;
                }
                numbersCount[number]++;
            }
            foreach (var item in numbersCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}