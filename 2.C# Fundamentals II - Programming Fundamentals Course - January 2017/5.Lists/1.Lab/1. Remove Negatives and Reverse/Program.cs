namespace _1.Remove_Negatives_and_Reverse
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Input.RemoveAll(x => x < 0);
            Input.Reverse();
            if (Input.Any())
            {
                Console.WriteLine(string.Join(" ", Input));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
}
