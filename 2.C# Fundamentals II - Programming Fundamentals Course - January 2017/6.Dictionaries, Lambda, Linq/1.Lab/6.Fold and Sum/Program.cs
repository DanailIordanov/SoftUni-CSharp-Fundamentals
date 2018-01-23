namespace _6.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var Input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = Input.Length / 4;

            var left = Input.Take(k).Reverse().ToArray();
            var right = Input.Reverse().Take(k).ToArray();

            var FirstRow = left.Concat(right).ToArray();
            var SecondRow = Input.Skip(k).Take(2 * k).ToArray();
            var Result = new List<int>();

            for (int i = 0; i < FirstRow.Length; i++)
            {
                Result.Add(FirstRow[i] + SecondRow[i]);
            }

            Console.WriteLine(string.Join(" ", Result));
        }
    }
}
