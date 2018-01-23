using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Condense_Array_to_Number
{
    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var condensed = new int[nums.Length - 1];

            if (nums.Length == 1)
            {
                Console.WriteLine($"{nums[0]} is already condensed to number");
            }
            else
            {
                for (int i = nums.Length; i > 1; i--)
                {
                    for (int j = 0; j < condensed.Length; j++)
                    {
                        condensed[j] = nums[j] + nums[j + 1];
                    }
                    condensed.CopyTo(nums, 0);
                }
                Console.WriteLine(string.Join(" ", condensed[0]));
            }
        }
    }
}
