using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a number");
            String s = System.Console.ReadLine();

            double d = Convert.ToDouble(s);


            double a = Math.Sqrt(d);

            System.Console.WriteLine("The result is {0:0.000}", a);


        }
    }
}
