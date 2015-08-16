using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter three-digit integer.");
            string x1 = System.Console.ReadLine();
            double x = System.Convert.ToInt32(x1);

            if ((x > 99) && (x < 1000))
            {
                double a = Math.Floor(x / 100);
                double b = Math.Floor((x - 100 * a) / 10);
                double c = x - a * 100 - b * 10;

                double y = Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3);

                if (y == x)
                    {
                    System.Console.WriteLine("The number {0} is the Armstrong number!", x);
                }
                else
                {
                    System.Console.WriteLine("Sorry, The number {0} is not the Armstrong number.", x);
                }
            }
            else
            {
                System.Console.WriteLine("The number you have enter is not a three-digit number.");

            }

        }
    }
}