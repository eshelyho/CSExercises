using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the number!");
            string n = System.Console.ReadLine();
            double N = System.Convert.ToDouble(n);

            Random rnd = new Random();
            if ( N > 1 || N < 0)
            {
                Double G = rnd.NextDouble() * (N - 1) + 1;
                while (G * G != N)
                {
                    G = (G + N / G) / 2;
                }
                System.Console.WriteLine("The square root of {0} is {1:0.00000}", N, G);
            }
            else if (N < 1)
            {
                Double G = rnd.NextDouble() * (1 - N) + N;
                while (G * G != N)
                {
                    G = (G + N / G) / 2;
                }
                System.Console.WriteLine("The square root of {0} is {1:0.00000}", N, G);
            }
            else
            {
                System.Console.WriteLine("The square root of {0} is 1");
            }







        }
    }
}
