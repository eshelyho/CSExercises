using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the number!");
            int i = System.Convert.ToInt32(Console.ReadLine());
            System.Console.Write("\n");

            double f;
            for (f = 1; f<i; f++)
            {
                System.Console.Write(f+"*");
                 
            }
            System.Console.Write(i);
            System.Console.Write("\n");
            System.Console.Write("\n");

            System.Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  -  ");
            System.Console.Write("\n");
            System.Console.Write(i);

            for (f = i-1; f>0; f--)
            {
                System.Console.Write("*"+f);
                 
            }
            System.Console.Write("\n");
            System.Console.Write("\n");
            
        }
    }
}
