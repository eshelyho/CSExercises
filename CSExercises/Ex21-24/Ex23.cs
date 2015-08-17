using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int mind = rnd.Next(0, 9);

            System.Console.WriteLine("Please guess the number!(0-9)");
            string e = System.Console.ReadLine();
            int i = System.Convert.ToInt32(e);
            int t = 1;

            if ((i>=0) && (i<=9))
            {
                while (i != mind)
              {
                t = t + 1;
                System.Console.WriteLine("Wrong! Try again!");
                e = System.Console.ReadLine();
                i = System.Convert.ToInt32(e);
              }
              if (t<=2)
              {
                  System.Console.WriteLine("Correct! You are a Wizard. You only use {0} attempts!", t);
              }
              else if ((t > 2) && (t <= 5))
              {
                  System.Console.WriteLine("Correct! You are a good guess. You only use {0} attempts!", t);
              }
              else if (t > 5)
              {
                  System.Console.WriteLine("Correct! You are a lousy! You use {0} attempts!", t);
              }
                
            }
            else
            {
                  System.Console.WriteLine("Please enter the right number!");
            }

        }
    }
}
