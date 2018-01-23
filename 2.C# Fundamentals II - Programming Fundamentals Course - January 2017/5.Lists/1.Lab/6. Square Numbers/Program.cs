namespace _6.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var Input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var Result = new List<double>();
            for (int i = 0; i < Input.Count; i++)
            {
                if (Math.Sqrt(Input[i]) == (int)(Math.Sqrt(Input[i])))
                {
                    Result.Add(Input[i]);
                }
            }
            Result.Sort();
            Result.Reverse();
            Console.WriteLine(string.Join(" ", Result));
        }
    }
}
