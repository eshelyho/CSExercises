using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the distance travelled.");
            string sdt = System.Console.ReadLine();
            double ddt = System.Convert.ToDouble(sdt);
            double dt = Math.Ceiling(ddt * 10) / 10;

            NumberFormatInfo curr = new CultureInfo("en-US", false).NumberFormat;

            if (dt <= 0.5) 
            {
                double cost1 = 2.4;
                System.Console.WriteLine("The cost is " + cost1.ToString("C", curr));
            }
            else if ((dt > 0.5) && (dt <= 9.0))
            {
                double cost2 = 2.4 + (dt-0.5)*10*0.04;
                System.Console.WriteLine("The cost is " + cost2.ToString("C", curr));
            }
            else if (dt > 9.0)
            {
                double cost3 = 2.4 + 85*0.04 + (dt-9.0)*10*0.05;
                System.Console.WriteLine("The cost is " + cost3.ToString("C", curr));
            }

        }
    }
}