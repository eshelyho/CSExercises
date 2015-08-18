using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            double X;
            double Y;
            System.Console.WriteLine("X\t\tY");
            System.Console.WriteLine("-  -  -  -  -  -  -  -  -  -  ");

            for (X = -6; X < 5; )
            {
                X = X + 1;
                Y = 2 * Math.Pow(X, 2) - 4 * X + 3;
                System.Console.WriteLine("{0:0.0}\t\t{1:0.0}", X,Y);
            }
           System.Console.WriteLine("-  -  -  -  -  -  -  -  -  -  ");

            for (X = 1; X < 20; X++)
            {
                Y = 2 * Math.Pow(X, 2) - 4 * X + 3;

                int i;
                for (i = 0; i < Y; i++ )
                {
                    System.Console.Write("*");
                }
                System.Console.Write("\n");
   
            }


        }
    }
}
