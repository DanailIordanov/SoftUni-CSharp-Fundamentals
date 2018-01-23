namespace _3.Min__Max__Sum__Average
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}