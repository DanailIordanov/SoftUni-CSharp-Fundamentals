namespace _5.Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var Buffer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int specialNumber = Buffer[0];
            int detonation = Buffer[1];

            for (int i = 0; i < Input.Count; i++)
            {
                if (Input[i] == specialNumber)
                {
                    int left = Math.Max(0, i - detonation);

                    int right = Math.Min(i + detonation, Input.Count - 1);

                    int length = right - left + 1;

                    Input.RemoveRange(left, length);

                    i = 0;
                }
            }
            Console.WriteLine(Input.Sum());
        }
    }
}
