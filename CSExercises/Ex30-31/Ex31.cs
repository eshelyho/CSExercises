using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {

            double n;
            for (n = 1; n < 1001; n++)
            {
                double f = 0;
                double i;

                for (i = 1; i < n; i++)
                {
                    if (f < n)
                    {
                        f = f + i;
                    }


                }
                if (f == n)
                {
                    System.Console.WriteLine(n);
                }



            }

        }
    }
}
