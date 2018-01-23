using System;
namespace _3.Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var Input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int currentValue = 0; currentValue < Input.Count - 1; currentValue++)
            {
                while (currentValue < Input.Count - 1)
                {
                    int nextValue = currentValue + 1;
                    if (Input[currentValue] == Input[nextValue])
                    {
                        double sum = Input[currentValue] + Input[nextValue];
                        Input[currentValue] = sum;
                        Input.RemoveAt(currentValue + 1);
                        if (currentValue > 0)
                        {
                            currentValue--;
                        }
                    }
                    else
                    {
                        currentValue++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", Input));
        }

    }
}
