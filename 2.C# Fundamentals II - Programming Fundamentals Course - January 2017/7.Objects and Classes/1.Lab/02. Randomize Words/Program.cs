namespace _02.Randomize_Words
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var Input = Console.ReadLine().Split();
            var Position = new Random();

            for (int i = 0; i < Input.Length; i++)
            {
                var currentWord = Input[i];
                var randomIndex = Position.Next(0, Input.Length);
                var tempWord = Input[randomIndex];
                Input[i] = tempWord;
                Input[randomIndex] = currentWord;
            }
            foreach (var word in Input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
