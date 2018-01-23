namespace _06.Rectangle_Position
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var firstRectangle = new Rectangle()
            {
                Left = firstInput[0],
                Top = firstInput[1],
                Width = firstInput[2],
                Height = firstInput[3]
            };
            var secondInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var secondRectangle = new Rectangle()
            {
                Left = secondInput[0],
                Top = secondInput[1],
                Width = secondInput[2],
                Height = secondInput[3]
            };

            Console.WriteLine(IsInside(firstRectangle, secondRectangle) ? "Inside" : "Not Inside");
        }
        public static bool IsInside(Rectangle First, Rectangle Second)
        {
            var leftIsCorrect = First.Left >= Second.Left;
            var rightIsCorrect = First.Right <= Second.Right;
            var bottomIsCorrect = First.Bottom <= Second.Bottom;
            var topIsCorrect = First.Top >= Second.Top;

            return leftIsCorrect && rightIsCorrect && bottomIsCorrect && topIsCorrect;
        }
    }
}
