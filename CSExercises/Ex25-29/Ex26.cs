using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double i;


            System.Console.WriteLine("No.\t\tinverse\t\tSQUARE ROOT\t\tSQUARE");
            System.Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   ");

            for (i=0; i<10; )
            {
                i=i+1;


                System.Console.WriteLine("{0:0.0}\t\t{1:0.0##}\t\t{2:0.0##}\t\t\t{3:0.0}", i, 1 / i, Math.Sqrt(i), Math.Pow(i, 2));


            }
        }
    }
}
