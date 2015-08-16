using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the side a.");
            string a1 = System.Console.ReadLine();
            double a = System.Convert.ToDouble(a1);

            System.Console.WriteLine("Please enter the side b.");
            string b1 = System.Console.ReadLine();
            double b = System.Convert.ToDouble(b1);

            System.Console.WriteLine("Please enter the side c.");
            string c1 = System.Console.ReadLine();
            double c = System.Convert.ToDouble(c1);

            if ((a < 1) || ( b<1 ) || (c < 1))
            {
                System.Console.WriteLine("Please enter the right number!");
            }
            else
            {
                if ((a + b <= c) || (a + c <= b) || (c + b <= a))
                    {
                    System.Console.WriteLine("Please enter the right number!");
                    }

                
                else
                {
                    double s = (a + b + c) / 2;
                    double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                    System.Console.WriteLine("The area of the traigle is {0}.", area);

                }

            }


        }
    }
}