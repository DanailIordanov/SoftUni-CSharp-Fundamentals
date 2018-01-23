using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(string.Join("", input.Reverse()));
        }
    }
}
}
