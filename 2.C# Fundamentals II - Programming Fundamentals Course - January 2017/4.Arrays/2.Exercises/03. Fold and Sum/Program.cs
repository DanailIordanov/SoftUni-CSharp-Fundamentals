using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var FullArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            // Left Part
            var Left = new int[FullArray.Length / 4];
            int indexLeft = 0;
            for (int i1 = 0; i1 < FullArray.Length / 4; i1++)
            {
                Left[indexLeft] = FullArray[i1];
                indexLeft++;
            }
            // Right Part
            var Right = new int[FullArray.Length / 4];
            int indexRight = 0;
            for (int i2 = FullArray.Length * 3 / 4; i2 < FullArray.Length; i2++)
            {
                Right[indexRight] = FullArray[i2];
                indexRight++;
            }
            // Middle Part
            int indexMid = 0;
            var SecondRow = new int[FullArray.Length / 2];
            for (int i3 = FullArray.Length / 4; i3 < FullArray.Length * 3 / 4; i3++)
            {
                SecondRow [indexMid] = FullArray[i3];
                indexMid++;
            }
            var newLeft = Left.Reverse().ToArray();
            var newRight = Right.Reverse().ToArray();
            var FirstRow = newLeft.Concat(newRight).ToArray();
            //Sum
            var sum = new int[FullArray.Length / 2];
            for (int i = 0; i < FullArray.Length / 2; i++)
            {
                sum[i] = FirstRow[i] + SecondRow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
