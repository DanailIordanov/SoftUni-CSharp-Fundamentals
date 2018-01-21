using System;

namespace _5.Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int currentDay;
            if (day > 23 && month == 2)
            {
                currentDay = day - 23;
                month++;
            }
            else if ((day > 25) && (month == 4 || month == 6 || month == 9 || month == 11))
            {
                currentDay = day - 25;
                month++;
            }
            else if ((day > 26) && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10))
            {
                currentDay = day - 26;
                month++;
            }
            else if ((day > 26) && month == 12)
            {
                currentDay = day - 26;
                month = 1;
            }
            else
            {
                currentDay = day += 5;
            }
            if (month < 10)
            {
                Console.WriteLine($"{currentDay}.0{month}");
            }
            else
            {
                Console.WriteLine($"{currentDay}.{month}");
            }
        }
    }
}
