namespace _01.Sweet_Dessert
{
    using System;

    class Program
    {
        static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());
            var guests = long.Parse(Console.ReadLine());
            var priceBananas = decimal.Parse(Console.ReadLine());
            var priceEggs = decimal.Parse(Console.ReadLine());
            var priceKiloBerries = decimal.Parse(Console.ReadLine());

            var numberOfPortions = Math.Ceiling((decimal)guests/6);
            var neededBananas = 2;
            var neededEggs = 4;
            var neededBerries = 0.2m;

            var endMoney = numberOfPortions * (neededBananas * priceBananas + neededEggs * priceEggs + neededBerries * priceKiloBerries);
            var neededMoney = endMoney - money;

            if (endMoney <= money)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {endMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
        }
    }
}
