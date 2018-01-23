﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var sequence = new long[n];
            sequence[0] = 1;
            for (int i = 1; i < n; i++)
            {
                for (int prev = i - 1; prev >= Math.Max(0, i - k); prev--)
                {
                    sequence[i] += sequence[prev];
                }
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
