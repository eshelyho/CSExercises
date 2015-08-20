using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter string 1.");
            string s1 = System.Console.ReadLine();
            System.Console.WriteLine("Please enter string 2.");
            string s2 = System.Console.ReadLine();

            if (InString(s1, s2))
                System.Console.WriteLine("include");
            else
                System.Console.WriteLine("Not include");
        }

        public static bool InString(string s1, string s2)
        {
            int flag = 0;
            int i;

            for (i = 0; i < s1.Length - s2.Length+1;i++ )
            {
                string s = s1.Substring(i, s2.Length);
                if (s == s2)
                {
                    flag = 1;
                }

            }
            if (flag == 1)
                return true;
            else
                return false;
        }
    }
}
