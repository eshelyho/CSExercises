using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number");
            long x = System.Convert.ToInt64(System.Console.ReadLine());
            Factorial(x);
        
        }
        public static long Factorial(long x)
        {
            for (double f = 1; f < x; f++)
            {
                System.Console.Write(f + "*");
            }
                System.Console.Write(x+"\n");
            return 0;
        }


        


    }
}
