using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int i;
            int min = 0;
            int max = 0;
            double avg = 0;
            int imin = 0;
            int imax = 0;
            
            int[] M = new int[12];
            
            for (i=0; i<12; i++)
            {
                System.Console.Write("Enter sales for month {0}: ", i);
                M[i]=System.Convert.ToInt32(System.Console.ReadLine());

                max = M.Max();
                min = M.Min();
                avg = M.Average();
            }
            for (i = 0; i < 12; i++)
            {
                if (max == M[i])
                {
                    imax = i;
                }

            }
            for (i = 0; i < 12; i++)
            {
                if (min == M[i])
                {
                    imin = i;
                }
                

            }
                System.Console.WriteLine("Maximun Sales: {0}\nMinimum Sales: {1}\nAverage Sales: {2}", imax, imin, avg);
        }
    }
}
