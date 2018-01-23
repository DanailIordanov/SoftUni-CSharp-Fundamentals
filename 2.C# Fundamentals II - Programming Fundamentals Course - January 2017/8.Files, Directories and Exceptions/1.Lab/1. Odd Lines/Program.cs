namespace _1.Odd_Lines
{
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            var file = "myfile.txt";
            var lines = File.ReadAllLines(file);
            var linesWithNumbers = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                linesWithNumbers.Add($"{i + 1}. {lines[i]}");
            }
            File.WriteAllLines("result.txt", linesWithNumbers);
        }
    }
}
