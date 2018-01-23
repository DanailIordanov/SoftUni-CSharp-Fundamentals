namespace _5.Folder_Size
{
    using System;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var totalLength = Directory
                .GetFiles("TestFolder")
                .Select(f => new FileInfo(f))
                .Sum(f => f.Length / 1024.0 / 1024.0);
            Console.WriteLine(totalLength);
        }
    }
}
