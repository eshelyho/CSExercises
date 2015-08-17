using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the number!");
            int i = System.Convert.ToInt32(Console.ReadLine());


            double f;
            for (f = 1; f<=i; f++)
            {
                double d = i / f;
                if (d - Math.Floor(d) == 0)
                {
                    System.Console.WriteLine(d);
                }
            }
            System.Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  -  ");
            for (f = i; f>= 1; f--)
            {
                double d = i / f;
                if (d - Math.Floor(d) == 0)
                {
                    System.Console.WriteLine(d);
                }
            }
            
        }
    }
}
