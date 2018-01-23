namespace _1.Count_Working_Days
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine();
            var startDate = DateTime.ParseExact(firstInput, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var secondInput = Console.ReadLine();
            var endDate = DateTime.ParseExact(secondInput, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var workingDaysCounter = 0;

            var notWorkingDays = new List<DateTime>()
            {
                new DateTime(2000, 01, 01),
                new DateTime(2000, 03, 03),
                new DateTime(2000, 05, 01),
                new DateTime(2000, 05, 06),
                new DateTime(2000, 05, 24),
                new DateTime(2000, 09, 06),
                new DateTime(2000, 09, 22),
                new DateTime(2000, 11, 01),
                new DateTime(2000, 12, 24),
                new DateTime(2000, 12, 25),
                new DateTime(2000, 12, 26)
            };

            for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                DateTime temp = new DateTime(2000, currentDate.Month, currentDate.Day); 
                if (!notWorkingDays.Contains(temp) && currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDaysCounter++;
                }
            }
            Console.WriteLine(workingDaysCounter);
        }
    }
}
