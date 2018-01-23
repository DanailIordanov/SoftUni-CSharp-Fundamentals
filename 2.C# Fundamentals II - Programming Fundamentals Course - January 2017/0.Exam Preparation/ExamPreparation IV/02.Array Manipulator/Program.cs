namespace Array_Manipulator
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var line = Console.ReadLine();
            while (line != "end")
            {
                var command = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "exchange":
                        var index = int.Parse(command[1]);
                        if (index < 0 || index >= arr.Length)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        arr = Exchange(arr, index);
                        break;
                    case "min":
                    case "max":
                        if (true)
                        {

                        }
                        FindMinMax(arr, command[0], command[1]);
                        break;
                    case "first":
                    case "last":
                        var count = int.Parse(command[1]);
                        if (count > arr.Length)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        FirstOrLastElements(arr, command[0], count, command[2]);
                        break;
                }
                line = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        public static void FirstOrLastElements(int[] arr, string command, int count, string evenOrOdd)
        {
            var filter = arr
                .Where(n => evenOrOdd == "even"
                    ? n % 2 == 0
                    : n % 2 == 1);
            int[] result;
            if (command == "first")
            {
                result = filter.Take(count).ToArray();
            }
            else
            {
                result = filter.Reverse().Take(count).Reverse().ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        public static void FindMinMax(int[] arr, string command, string evenOrOdd)
        {
            var filter = arr
                .Where(n => evenOrOdd == "even"
                    ? n % 2 == 0
                    : n % 2 == 1);
            if (!filter.Any())
            {
                Console.WriteLine("No matches");
                return;
            }
            var result = command == "max" 
                    ? filter.Max() 
                    : filter.Min();
            Console.WriteLine(Array.LastIndexOf(arr, result));
       }

        public static int[] Exchange(int[] arr, int index)
        {
            var secondArray = new int[index + 1];
            for (int i = 0; i <= index; i++)
            {
                secondArray[i] = arr[i];
            }
            var finalArray = arr.Skip(index + 1).Concat(secondArray).ToArray();
            return finalArray;
        }
    }
}
