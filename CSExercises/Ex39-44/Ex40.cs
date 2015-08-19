using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            int i;
            for (i=1;i<26;i++)
            {
                System.Console.WriteLine("The square root of {0} is {1:0.000}", i, SQT(i));
            }
        }

        public static double SQT(int y)
        {
            if (y > 0)
            {
                return Math.Sqrt(y);
            }
            else return 0;
        }
    }
}
