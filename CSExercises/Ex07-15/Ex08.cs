using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the temperature as Centigrade scale");
            String s = System.Console.ReadLine();

            double c = System.Convert.ToInt32(s);

            double f = 1.8 * c + 32;

            System.Console.WriteLine("The Fahrenheit is {0}", f);


        }
    }
}
