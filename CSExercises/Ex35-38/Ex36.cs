using System;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a string.");
            string s = System.Console.ReadLine();
            s = s.ToLower(); //for 36b.
            int i = 0;
            int j;
            int notice = 0;
            double k;

            k = Math.Floor(Convert.ToDouble(s.Length / 2));
            for (i = 0, j = s.Length - 1; i < k && j > k; i++, j--)
            {
                if (s.Substring(i,1)!=s.Substring(j,1))
                {
                    notice = 1; //remind this is not the palidrom
                }
            }
            if (notice==1)
            {
                System.Console.WriteLine("Not Palindrome");
            }
            else
            {
                System.Console.WriteLine("Palindrome");
            }
        }
    }
}