using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the number!");
            int n = System.Convert.ToInt32(Console.ReadLine());

            double f = 0;
            double i;

            for (i = 1; i <= n; i++)
            {
                if (f < n)
                {
                    f = f + i;
                }
            }


            if (f == n)
            {
                System.Console.WriteLine("The number is perfect.");
            }
            else
            {
                System.Console.WriteLine("The number is not perfect.");
            }
        }
    }
}
