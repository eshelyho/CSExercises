using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            double n;


            for (n=5; n<10001; n++)
            {
                double f;
                double i = 0;
                for (f = 1; f <= n; f++)
                {
                    double d = n / f;
                    if (d - Math.Floor(d) == 0)
                    {
                        i = i + 1;
                    }
                }
                if (i == 2)
                {
                    System.Console.WriteLine(n);
                }




            }


        }
    }
}
