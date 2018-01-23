using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    public class Program
    {

        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string whichMethod = Console.ReadLine();
            if (whichMethod == "face")
            {
                Console.WriteLine("{00:F}", FaceDiagonal(side));
            }
            else if (whichMethod == "space")
            {
                Console.WriteLine("{00:F}", spaceDiagonal(side));
            }
            else if (whichMethod == "volume")
            {
                Console.WriteLine("{00:F}", Volume(side));
            }
            else
            {
                Console.WriteLine("{00:F}", Area(side));
            }
        }
        public static double FaceDiagonal(double a)
        {
            double faceDiagonal = Math.Sqrt(2*Math.Pow(a,2));
            return faceDiagonal;
        }
        public static double spaceDiagonal(double a)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(a, 2));
            return spaceDiagonal;
        }
        public static double Volume(double a)
        {
            double Volume = a * a * a;
            return Volume;
        }
        public static double Area(double a)
        {
            double Area = 6 * a * a;
            return Area;
        }

    }
}
