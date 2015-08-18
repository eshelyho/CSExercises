using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the number!");
            int N = System.Convert.ToInt32(Console.ReadLine());

            double f;
            double i = 0;
            for (f = 1; f <= N; f++)
            {
                double d = N / f;
                if (d - Math.Floor(d) == 0)
                {
                    i = i + 1;
                }
            }
            if (i == 2 || i == 1)
            {
                System.Console.WriteLine("Prime");
            }
            else
            {
                System.Console.WriteLine("Not Prime");
            }
        }
    }
}
