using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            double avg;
            System.Console.WriteLine("No. \tA\tB\tC\tD\tTotal");
            int[,] mark = new int[12, 4];
            mark[0, 0] = 56; mark[0, 1] = 84; mark[0, 2] = 68; mark[0, 3] = 29;
            mark[1, 0] = 94; mark[1, 1] = 73; mark[1, 2] = 31; mark[1, 3] = 89;
            mark[2, 0] = 41; mark[2, 1] = 63; mark[2, 2] = 36; mark[2, 3] = 90;
            mark[3, 0] = 99; mark[3, 1] = 9; mark[3, 2] = 18; mark[3, 3] = 17;
            mark[4, 0] = 62; mark[4, 1] = 3; mark[4, 2] = 65; mark[4, 3] = 75;
            mark[5, 0] = 40; mark[5, 1] = 96; mark[5, 2] = 53; mark[5, 3] = 23;
            mark[6, 0] = 81; mark[6, 1] = 15; mark[6, 2] = 27; mark[6, 3] = 30;
            mark[7, 0] = 21; mark[7, 1] = 70; mark[7, 2] = 100; mark[7, 3] = 22;
            mark[8, 0] = 88; mark[8, 1] = 50; mark[8, 2] = 13; mark[8, 3] = 12;
            mark[9, 0] = 48; mark[9, 1] = 54; mark[9, 2] = 52; mark[9, 3] = 78;
            mark[10, 0] = 64; mark[10, 1] = 71; mark[10, 2] = 67; mark[10, 3] = 25;
            mark[11, 0] = 16; mark[11, 1] = 93; mark[11, 2] = 46; mark[11, 3] = 72;
             
            int i;
            int j;
            double sum = 0;

            for (i = 0; i < 12; i++)
            {
                double st = 0;

                System.Console.Write("{0}\t", i+1);
                for (j = 0; j < 4; j++)
                {
                    st = st+mark[i,j];
                    System.Console.Write("{0}\t", mark[i, j]);
                    sum = sum + mark[i,j];
                }
                System.Console.WriteLine("{0}", st);
                
            }
            for (j=0;j<4;j++)
            {
                double m = 0;
                double sm = 0;
                double v = 0;
                for (i=0;i<12;i++)
                {
                    m = m + mark[i, j];
                }
                for (i=0;i<12;i++)
                {

                    sm = sm + Math.Pow(mark[i, j] - m / 12, 2);
                    v = Math.Sqrt(sm / 12);
                }

                System.Console.WriteLine("Standard Deviation\t {0}", v);
                 
            }
            //System.Console.WriteLine(sum);
            avg = sum/48;
            System.Console.WriteLine("The average is {0}.", avg);





        }
    }
}
