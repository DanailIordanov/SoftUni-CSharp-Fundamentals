namespace _07.Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var DictionaryofSales = new SortedDictionary<string, double>();

            for (int i = 1; i <= n; i++)
            {
                var currentLine = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                var currentInput = new Sales()
                {
                    Town = currentLine[0],
                    Product = currentLine[1],
                    Price = double.Parse(currentLine[2]),
                    Quantity = double.Parse(currentLine[3])
                };
                if (!DictionaryofSales.ContainsKey(currentInput.Town))
                {
                    DictionaryofSales[currentInput.Town] = currentInput.Price * currentInput.Quantity;
                }
                else
                {
                    DictionaryofSales[currentInput.Town] += currentInput.Price * currentInput.Quantity;
                }
            }
            foreach (var item in DictionaryofSales)
            {
                Console.WriteLine($"{item.Key:F2} -> {item.Value:F2}");
            }
        }
    }
}
