using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a number as x1.");
            String x01 = System.Console.ReadLine();
            double x1 = System.Convert.ToDouble(x01);

            System.Console.WriteLine("Please enter a number as x2.");
            String x02 = System.Console.ReadLine();
            double x2 = System.Convert.ToDouble(x02);

            System.Console.WriteLine("Please enter a number as y1.");
            String y01 = System.Console.ReadLine();
            double y1 = System.Convert.ToDouble(y01);

            System.Console.WriteLine("Please enter a number as y2.");
            String y02 = System.Console.ReadLine();
            double y2 = System.Convert.ToDouble(y02);

            double x = Math.Pow(x2 - x1, 2);
            double y = Math.Pow(y2 - y1, 2);
            double d = Math.Sqrt(x - y);

            System.Console.WriteLine("The Dinstance between the points is {0}.", d);

        }
    }
}
