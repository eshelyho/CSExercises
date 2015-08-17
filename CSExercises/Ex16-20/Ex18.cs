using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the mark.");
            string mark1 = System.Console.ReadLine();
            int mark = System.Convert.ToInt32(mark1);

            if ((mark > 100) || (mark < 0)) 
            {
                System.Console.WriteLine("**Error**");
            }
            else if ((mark >= 80) && (mark <= 100)) 
            {
                System.Console.WriteLine("Your scored {0} marks which is A grade.", mark);
            }
            else if ((mark >= 60) && (mark <= 79))
            {
                System.Console.WriteLine("Your scored {0} marks which is B grade.", mark);
            }
            else if ((mark >= 40) && (mark <= 59))
            {
                System.Console.WriteLine("Your scored {0} marks which is C grade.", mark);
            }
            else if ((mark >= 0) && (mark <= 39))
            {
                System.Console.WriteLine("Your scored {0} marks which is F grade.", mark);
            }
        }
    }
}