using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter string.");
            string s = System.Console.ReadLine();
            System.Console.WriteLine("Please enter character 1.");
            char c1 = Convert.ToChar(Console.ReadLine());
            System.Console.WriteLine("Please enter character 2.");
            char c2 = Convert.ToChar(Console.ReadLine());

            if (Substitute(s, c1, c2) != null)
                System.Console.WriteLine("The result is {0}", Substitute(s, c1, c2));
            else
                System.Console.WriteLine("Can not find");
        }

          public static string Substitute(string s, char c1, char c2)
          {
              int i;
              string a = s;
              int flag = 0;
        
          for (i = 0; i < s.Length; i++)
          {
              if (s.Substring(i, 1) == Convert.ToString(c1))
              {
                  flag = 1;
                  a = s.Substring(0, i) + c2 + s.Substring(i + 1, s.Length - i - 1);
              }
        
           }
        
           if (flag == 1)
               return a;
           else
               return null;

        }

        }
    }
