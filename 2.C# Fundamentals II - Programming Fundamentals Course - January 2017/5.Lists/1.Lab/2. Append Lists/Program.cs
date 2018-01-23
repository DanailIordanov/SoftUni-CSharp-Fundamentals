namespace _2.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var Input = Console.ReadLine().Split('|').ToList();
            Input.Reverse();
            var Result = new List<string>();

            foreach (var token in Input)
            {
                List<string> Text = token.Split(' ').ToList();
                foreach (var number in Text)
                {
                    if (number != "")
                    {
                        Result.Add(number);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", Result));
        }
    }
}
