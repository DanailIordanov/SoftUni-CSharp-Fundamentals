namespace _2.Advertisement_Message
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var Phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            var Events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            var Authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            var Cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            var randomIndex = new Random();
            var times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                var phraseIndex = randomIndex.Next(0, Phrases.Length);
                var eventIndex = randomIndex.Next(0, Events.Length);
                var authorIndex = randomIndex.Next(0, Authors.Length);
                var cityIndex = randomIndex.Next(0, Cities.Length);

                Console.WriteLine($"{Phrases[phraseIndex]} {Events[eventIndex]} {Authors[authorIndex]} - {Cities[cityIndex]}");
            }
        }
    }
}
