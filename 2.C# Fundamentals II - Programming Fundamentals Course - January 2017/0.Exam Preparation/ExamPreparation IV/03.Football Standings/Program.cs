namespace Football_Standings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            key = Regex.Escape(key);
            var regex = new Regex($@"{key}(.*?){key}.+?{key}(.*?){key}.+?(\d+):(\d+)");
            var scores = new Dictionary<string, int>();
            var goals = new Dictionary<string, long>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "final")
                {
                    break;
                }
                var match = regex.Match(line);

                var firstTeamReverse = match.Groups[1].Value.Reverse().ToArray();
                var secondTeamRevere = match.Groups[2].Value.Reverse().ToArray();

                var firstTeam = new string(firstTeamReverse).ToUpper();
                var secondTeam = new string(secondTeamRevere).ToUpper();
                var firstScore = int.Parse(match.Groups[3].Value);
                var secondScore = int.Parse(match.Groups[4].Value);
                ////
                if (!scores.ContainsKey(firstTeam))
                {
                    scores[firstTeam] = 0;
                }
                if (!scores.ContainsKey(secondTeam))
                {
                    scores[secondTeam] = 0;
                }
                if (!goals.ContainsKey(firstTeam))
                {
                    goals[firstTeam] = 0;
                }
                if (!goals.ContainsKey(secondTeam))
                {
                    goals[secondTeam] = 0;
                }
                ////
                if (firstScore > secondScore)
                {
                    scores[firstTeam] += 3;
                }
                else if (firstScore < secondScore)
                {
                    scores[secondTeam] += 3;
                }
                else
                {
                    scores[firstTeam] += 1;
                    scores[secondTeam] += 1;
                }
                ////
                goals[firstTeam] += firstScore;
                goals[secondTeam] += secondScore;
            }
            Console.WriteLine("League standings:");
            var i = 1;
            foreach (var kvp in scores.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{i}. {kvp.Key} {kvp.Value}");
                i++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var kvp in goals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
