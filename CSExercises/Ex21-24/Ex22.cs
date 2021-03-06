using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter A.");
            string a1 = System.Console.ReadLine();
            int a = System.Convert.ToInt32(a1);
            System.Console.WriteLine("Please enter B.");
            string b1 = System.Console.ReadLine();
            int b = System.Convert.ToInt32(b1);

            int HCF;
            int LCM;
            int AB = a * b;

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else if (b > a)
                {
                    b = b - a;
                }
            }

            HCF = a;
            LCM = AB / HCF;

            System.Console.WriteLine("HCF: {0}", HCF);
            System.Console.WriteLine("LCM: {0}", LCM);

        }
    }
}