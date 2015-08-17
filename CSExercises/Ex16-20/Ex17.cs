using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter your name.");
            String name = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your gender. (M/F)");
            String gender = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your age.");
            string age1 = System.Console.ReadLine();
            int age = System.Convert.ToInt32(age1);

            if ((gender == "M") || (gender == "F"))
            {
                if (gender == "M")
                {
                    if ((age < 40) && (age > 0)) 
                    {
                        System.Console.WriteLine("Good Morning Mr. {0}.", name);
                    }
                    else if (age >= 40)
                    {
                        System.Console.WriteLine("Good Morning Uncle {0}.", name);
                    }
                    else if (age <= 0)
                    {
                        System.Console.WriteLine("Wrong age!");
                    }
                }

                else
                {
                    if ((age < 40) && (age >0))
                    {
                        System.Console.WriteLine("Good Morning Ms. {0}.", name);
                    }
                    else if (age >= 40)
                    {
                        System.Console.WriteLine("Good Morning Aunty {0}.", name);
                    } 
                    else if (age <= 0)
                    {
                        System.Console.WriteLine("Wrong age!");
                    }
                    
                }
            }
            else
            {
                System.Console.WriteLine("Wrong gender!");
            }  
        }
    }
}