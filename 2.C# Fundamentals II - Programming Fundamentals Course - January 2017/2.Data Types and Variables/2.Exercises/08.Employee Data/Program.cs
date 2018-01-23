using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            string e = Console.ReadLine();
            string f = Console.ReadLine();

            Console.WriteLine($"First name: {a}");
            Console.WriteLine($"Last name: {b}");
            Console.WriteLine($"Age: {c}");
            Console.WriteLine($"Gender: {d}");
            Console.WriteLine($"Personal ID: {e}");
            Console.WriteLine($"Unique Employee number: {f}");
        }
    }
}
