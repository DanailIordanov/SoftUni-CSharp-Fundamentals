using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine(
                   new string('*', n));
            }
        }
    }
}
