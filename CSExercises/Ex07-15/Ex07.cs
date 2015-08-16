using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the salar");
            String s = System.Console.ReadLine();

            double i = System.Convert.ToInt32(s);

            double sum = i * 1.13;

            NumberFormatInfo curr = new CultureInfo("en-US", false).NumberFormat;

            System.Console.WriteLine("Total income salary is " + sum.ToString("C", curr));

        }
    }
}
