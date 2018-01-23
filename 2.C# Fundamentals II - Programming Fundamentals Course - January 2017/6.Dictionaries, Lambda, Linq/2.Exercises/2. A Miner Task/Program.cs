namespace _2.A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MetalSum
    {
        public static void Main()
        {
            var metals = new Dictionary<string, int>();
            while (true)
            {
                var metal = Console.ReadLine();
                if (metal == "stop")
                {
                    break;
                }
                var number = int.Parse(Console.ReadLine());
                if (!metals.ContainsKey(metal))
                {
                    metals[metal] = number;
                }
                else
                {
                    metals[metal] += number;
                }
            }
            foreach (var item in metals)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
