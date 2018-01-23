namespace _4.Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var Input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '[', ']', '\\', }).ToList();
            var LowCase = new List<string>();
            var UpperCase = new List<string>();
            var MixedCase = new List<string>();

            var lowLetters = new List<char>();
            var upLetters = new List<char>();

            for (int i = 0; i < Input.Count; i++)
            {
                if (Input[i] != "")
                {
                    foreach (var letter in Input[i])
                    {
                        if (char.IsUpper(letter))
                        {
                            upLetters.Add(letter);
                        }
                        else if (char.IsLower(letter))
                        {
                            lowLetters.Add(letter);
                        }
                        else
                        {
                            lowLetters.Add(letter);
                            upLetters.Add(letter);
                        }
                    }
                    if (lowLetters.Count == 0 && upLetters.Count > 0)
                    {
                        UpperCase.Add(Input[i]);
                    }
                    else if (lowLetters.Count > 0 && upLetters.Count == 0)
                    {
                        LowCase.Add(Input[i]);
                    }
                    else
                    {
                        MixedCase.Add(Input[i]);
                    }
                    upLetters.Clear();
                    lowLetters.Clear();
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", LowCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", MixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", UpperCase)}");
        }
    }
}
