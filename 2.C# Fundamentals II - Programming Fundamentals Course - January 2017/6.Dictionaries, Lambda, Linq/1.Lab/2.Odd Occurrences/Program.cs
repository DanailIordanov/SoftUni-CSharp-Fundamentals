namespace _2.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(' ');
            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount[word] = 0;
                }
                wordCount[word]++;
            }

            var result = new List<string>();
            foreach (var item in wordCount)
            {
                if (item.Value % 2 == 1)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));

        }
    }
}