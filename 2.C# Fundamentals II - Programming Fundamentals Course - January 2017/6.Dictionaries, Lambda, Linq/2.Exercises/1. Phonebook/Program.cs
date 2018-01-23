using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "END")
                {
                    break;
                }

                if (input[0] == "A")
                {
                    var name = input[1];
                    var phoneNumber = input[2];

                    phonebook[name] = phoneNumber;
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        var contact = phonebook.Single(kvp => kvp.Key == input[1]);
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var kvp in phonebook)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }
            }

        }
    }
}
