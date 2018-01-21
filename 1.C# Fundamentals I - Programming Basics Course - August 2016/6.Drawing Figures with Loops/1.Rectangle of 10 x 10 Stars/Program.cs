using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('*', 10));
            }
        }
    }
}
