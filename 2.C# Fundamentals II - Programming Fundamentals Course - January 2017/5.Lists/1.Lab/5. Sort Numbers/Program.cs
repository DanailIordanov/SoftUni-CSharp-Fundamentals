namespace _5.Sort_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var Input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Input.Sort();
            Console.WriteLine(string.Join(" <= ", Input));
        }
    }
}
