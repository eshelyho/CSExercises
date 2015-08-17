using System;



namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter your name.");
            String name = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your gender. (M/F)");
            String gender = System.Console.ReadLine();

            if ((gender == "M") || (gender == "F"))
            {
                if (gender == "M")
                {
                    System.Console.WriteLine("Good Morning Mr. {0}.", name);
                }
                else
                {
                    System.Console.WriteLine("Good Mornig Ms. {0}.", name);
                }
            }
            else
            {
                System.Console.WriteLine("Wrong gender!");
            }
        }
    }
}