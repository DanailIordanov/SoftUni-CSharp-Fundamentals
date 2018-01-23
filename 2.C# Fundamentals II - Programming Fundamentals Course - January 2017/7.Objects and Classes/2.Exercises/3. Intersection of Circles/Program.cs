namespace _3.Intersection_of_Circles
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var firstProperties = Console.ReadLine().Split(' ').ToArray();
            var firstCircle = new Circle()
            {
                X = double.Parse(firstProperties[0]),
                Y = double.Parse(firstProperties[1]),
                Radius = double.Parse(firstProperties[2])
            };
            var secondProperties = Console.ReadLine().Split(' ').ToArray();
            var secondCircle = new Circle()
            {
                X = double.Parse(secondProperties[0]),
                Y = double.Parse(secondProperties[1]),
                Radius = double.Parse(secondProperties[2])
            };

            if (AreIntersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool AreIntersect(Circle First, Circle Second)
        {
            var differenceX = Math.Abs(First.X - Second.X);
            var differenceY = Math.Abs(First.Y - First.Y);
            var powerX = Math.Pow(differenceX, 2);
            var powerY = Math.Pow(differenceY, 2);
            var distance = Math.Sqrt(powerX + powerY);

            if (distance <= First.Radius + Second.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
