namespace _01.Day_of_Week
{
    using System;
    using System.Globalization;

    public class DayOfWeek
    {
        public static void Main()
        {
            var Input = Console.ReadLine();
            var Date = DateTime.ParseExact(Input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(Date.DayOfWeek);
            
        }
    }
}
