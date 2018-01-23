namespace _3.Fix_Emails
{
    using System;
    using System.Collections.Generic;

    public class EmailFixer
    {
        public static void Main()
        {
            var emails = new Dictionary<string, string>();
            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                var Email = Console.ReadLine();
                if (!emails.ContainsKey(name))
                {
                    emails[name] = Email;
                }
                if (Email.EndsWith("us") || Email.EndsWith("uk") || Email.EndsWith("UK") || Email.EndsWith("US"))
                {
                    emails.Remove(name);
                }
            }
            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
