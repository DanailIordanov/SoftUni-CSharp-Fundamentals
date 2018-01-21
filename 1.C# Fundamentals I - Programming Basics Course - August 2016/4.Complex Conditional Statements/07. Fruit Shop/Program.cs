using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double broi = double.Parse(Console.ReadLine());
            double cena;
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    cena = broi * 2.50;
                    Console.WriteLine(cena);
                }
                else if (fruit == "apple")
                {
                    cena = broi * 1.20;
                    Console.WriteLine(cena);
                }
                else if (fruit == "orange")
                {
                    cena = broi * 0.85;
                    Console.WriteLine(cena);
                }
                else if (fruit == "grapefruit")
                {
                    cena = broi * 1.45;
                    Console.WriteLine(cena);
                }
                else if (fruit == "kiwi")
                {
                    cena = broi * 2.70;
                    Console.WriteLine(cena);
                }
                else if (fruit == "pineapple")
                {
                    cena = broi * 5.50;
                    Console.WriteLine(cena);
                }
                else if (fruit == "grapes")
                {
                    cena = broi * 3.85;
                    Console.WriteLine(cena);
                }
            }

            if (day == "Sunday" || day == "Saturday")
            {
                if (fruit == "banana")
                {
                    cena = broi * 2.70;
                    Console.WriteLine(cena);
                }
                else if (fruit == "apple")
                {
                    cena = broi * 1.25;
                    Console.WriteLine(cena);
                }
                else if (fruit == "orange")
                {
                    cena = broi * 0.90;
                    Console.WriteLine(cena);
                }
                else if (fruit == "grapefruit")
                {
                    cena = broi * 1.60;
                    Console.WriteLine(cena);
                }
                else if (fruit == "kiwi")
                {
                    cena = broi * 3.00;
                    Console.WriteLine(cena);
                }
                else if (fruit == "pineapple")
                {
                    cena = broi * 5.60;
                    Console.WriteLine(cena);
                }
                else if (fruit == "grapes")
                {
                    cena = broi * 4.20;
                    Console.WriteLine(cena);
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
