using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a number as x.");
            String s = System.Console.ReadLine();

            double x = System.Convert.ToDouble (s);

            double y = 2 * Math.Pow(x, 2) - 4 * x + 3;

            System.Console.WriteLine("The y is {0}", y);

        }
    }
}
