namespace Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var participants = new SortedDictionary<string, Dictionary<long, decimal>>();
            for (int i = 0; i < names.Length; i++)
            {
                var dmg = GetDmg(names[i]);
                var hp = GetHP(names[i]);
                if (!participants.ContainsKey(names[i]))
                {
                    participants.Add(names[i], new Dictionary<long, decimal> { { hp, dmg } });
                }
                else
                {
                    participants[names[i]] = new Dictionary<long, decimal> { { hp, dmg } };
                }
            }
            foreach (var kvp in participants)
            {
                Console.Write($"{kvp.Key} - ");
                foreach (var stats in kvp.Value)
                {
                    Console.WriteLine($"{stats.Key} health, {stats.Value:F2} damage");
                }
            }
        }

        public static long GetHP(string name)
        {
            var regex = new Regex(@"([^0-9\.\*\+\-\/])");
            var matches = regex.Matches(name);
            var listOfMatches = new List<long>();
            foreach (Match match in matches)
            {
                var currentSymbol = char.Parse(match.Groups[1].Value);
                listOfMatches.Add((currentSymbol));
            }
            var hp = listOfMatches.Sum();
            return hp;
        }

        public static decimal GetDmg(string name)
        {
            var regex = new Regex(@"([+-]?[0-9]+(?:\.[0-9]+)?)");
            var matches = regex.Matches(name);
            var listOfMatches = new List<decimal>();
            foreach (Match match in matches)
            {
                var currentDigit = decimal.Parse(match.Groups[1].Value.TrimStart('+'));
                listOfMatches.Add(currentDigit);
            }
            var dmg = listOfMatches.Sum();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == '*')
                {
                    dmg *= 2;
                }
                if (name[i] == '/')
                {
                    dmg /= 2;
                }
            }
            return dmg;
        }
    }
}
