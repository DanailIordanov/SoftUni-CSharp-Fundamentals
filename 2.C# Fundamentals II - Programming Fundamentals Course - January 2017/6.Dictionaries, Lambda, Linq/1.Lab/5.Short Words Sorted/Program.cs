namespace _5.Short_Words_Sorted
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .ToList();
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
