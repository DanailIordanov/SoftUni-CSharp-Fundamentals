namespace Charity_Marathon
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var marathonDays = decimal.Parse(Console.ReadLine());
            var numberOfRunners = decimal.Parse(Console.ReadLine());
            var lapsPerRunner = decimal.Parse(Console.ReadLine());
            var trackLength = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

            var runnersToTakePart = Math.Min(trackCapacity * marathonDays, numberOfRunners);
            var kilometersInCompetition = (runnersToTakePart * lapsPerRunner * trackLength) / 1000;
            var moneyFromMarathon = moneyPerKilometer * kilometersInCompetition;

            Console.WriteLine($"Money raised: {moneyFromMarathon:F2}");
        }
    }
}
