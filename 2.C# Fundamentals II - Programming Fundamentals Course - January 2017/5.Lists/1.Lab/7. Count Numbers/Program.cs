namespace _7.Count_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if (Input.Count > 0)
            {
                Input.Sort();
                Input.Add(int.MaxValue);
                int previousNumber = Input[0];
                var count = 1;
                for (int i = 1; i < Input.Count; i++)
                {
                    int currentNumber = Input[i];
                    if (previousNumber == currentNumber)
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{previousNumber} -> {count}");
                        count = 1;
                    }
                    previousNumber = currentNumber;
                }
            }
        }
    }
}
