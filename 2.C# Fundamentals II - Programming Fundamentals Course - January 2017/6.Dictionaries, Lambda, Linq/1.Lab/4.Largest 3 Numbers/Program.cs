namespace _4.Largest_3_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}