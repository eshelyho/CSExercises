using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a number.");
            string no = System.Console.ReadLine();
            int i = System.Convert.ToInt32(no);

            while (i != 88)
            {
                System.Console.WriteLine("Please enter a number.");
                no = System.Console.ReadLine();
                i = System.Convert.ToInt32(no);
            }

            
                System.Console.WriteLine("Lucky you...");
            
        }
    }
}
