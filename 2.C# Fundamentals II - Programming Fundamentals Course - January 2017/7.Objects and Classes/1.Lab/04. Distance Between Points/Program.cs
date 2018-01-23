namespace _04.Distance_Between_Points
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            var firstPoint = new Point
            {
                X = firstInput[0],
                Y = firstInput[1]
            };

            var secondInput = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            var secondPoint = new Point
            {
                X = secondInput[0],
                Y = secondInput[1]
            };

            var Result = CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{Result:F3}");
        }
        public static double CalculateDistance( Point firstPoint, Point secondPoint)
        {
            var differenceX = firstPoint.X - secondPoint.X;
            var differenceY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(differenceX, 2);
            var powY = Math.Pow(differenceY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}
