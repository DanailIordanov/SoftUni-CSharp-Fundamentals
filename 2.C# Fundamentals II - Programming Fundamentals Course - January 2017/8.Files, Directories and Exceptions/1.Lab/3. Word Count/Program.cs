namespace _3.Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt")
                .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();
            var text = File.ReadAllText("text.txt")
                .Split(new[] { ' ', '?', '-', '.', '\'', '!', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToArray();
            
            var result = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var currentWord_Count = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    if (currentWord == text[j])
                    {
                        currentWord_Count++;
                    }
                }
                result[currentWord] = currentWord_Count;
            }
            var sortedResult = result
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => $"{kvp.Key} - {kvp.Value}")
                .ToArray();
            File.WriteAllLines("result.txt", sortedResult);
        }
    }
}
