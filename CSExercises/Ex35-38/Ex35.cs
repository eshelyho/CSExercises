using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a pharse");
            string pharse = Console.ReadLine();
            int a = 0; int e = 0; int i = 0; int o = 0; int u = 0;
            int z;
            
            for (z = 0; z < pharse.Length; z++)
            {
                if (pharse[z] == 'a') a++;
                if (pharse[z] == 'e') e++;
                if (pharse[z] == 'i') i++;
                if (pharse[z] == 'o') o++;
                if (pharse[z] == 'u') u++;

            }
            int total = a + e + i + o + u;

            if (total == 0)
            {
                System.Console.WriteLine("There is no vowels in the pharse.");
            }
            else
            {
                System.Console.WriteLine("Total number of vowels: {0}", total);
                System.Console.WriteLine("Number of a: {0}", a);
                System.Console.WriteLine("Number of e: {0}", e);
                System.Console.WriteLine("Number of i: {0}", i);
                System.Console.WriteLine("Number of o: {0}", o);
                System.Console.WriteLine("Number of u: {0}", u);
            }

        }
    }
}
