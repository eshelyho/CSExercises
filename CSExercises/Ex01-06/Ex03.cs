using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a number");
            String s = System.Console.ReadLine();

            double d = Convert.ToDouble(s);


            double a = Math.Pow(d, 2);

            System.Console.WriteLine("The result is {0}", a);

        }
    }
}
