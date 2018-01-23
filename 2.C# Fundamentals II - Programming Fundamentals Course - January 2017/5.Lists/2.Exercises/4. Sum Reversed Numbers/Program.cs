namespace _4.Sum_Reversed_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var Input = Console.ReadLine().Split(' ').ToList();

            var stringBuffer = new List<char>();
            var numbersList = new List<int>();

            foreach (string number in Input)
            {
                foreach (var digit in number)
                {
                    stringBuffer.Add(digit);
                }
                stringBuffer.Reverse();
                int numberFinal = int.Parse(string.Join("",stringBuffer));
                numbersList.Add(numberFinal);
                stringBuffer.Clear();
            }

            int sum = 0;
            for (int i = 0; i < numbersList.Count; i++)
            {
                sum += numbersList[i];
            }
            Console.WriteLine(sum);
        }
    }
}
