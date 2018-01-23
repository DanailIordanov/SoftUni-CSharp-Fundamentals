namespace _03.Big_Factorial
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
