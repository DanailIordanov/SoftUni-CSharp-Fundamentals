namespace _05.Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var Points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoints = Console.ReadLine().Split().Select(double.Parse).ToArray();
                var currentPoint = new Point
                {
                    X = currentPoints[0],
                    Y = currentPoints[1]
                };
                Points.Add(currentPoint);
            }
            var minDistance = double.MaxValue;
            Point firstPointMax = null;
            Point secondPointMax = null;

            for (int i = 0; i < Points.Count - 1; i++)
            {
                for (int j = i + 1; j < Points.Count; j++)
                {
                    var firstPoint = Points[i];
                    var secondPoint = Points[j];
                    var currentDistance = CalculateDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstPointMax = firstPoint;
                        secondPointMax = secondPoint;
                    }
                }
            }
            Console.WriteLine(minDistance);
            Console.WriteLine($"({firstPointMax.X}, {firstPointMax.Y})");
            Console.WriteLine($"({secondPointMax.X}, {secondPointMax.Y})");
        }
        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var differenceX = firstPoint.X - secondPoint.X;
            var differenceY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(differenceX, 2);
            var powY = Math.Pow(differenceY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}
