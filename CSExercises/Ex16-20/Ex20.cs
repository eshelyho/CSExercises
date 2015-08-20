using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter quantity for TV.");
            string stv= System.Console.ReadLine();
            int tv= System.Convert.ToInt32(stv);
            System.Console.WriteLine("Enter quantity for DVD.");
            string sdvd = System.Console.ReadLine();
            int dvd = System.Convert.ToInt32(sdvd);
            System.Console.WriteLine("Enter quantity for MP3.");
            string smp= System.Console.ReadLine();
            int mp3 = System.Convert.ToInt32(smp);

            NumberFormatInfo curr = new CultureInfo("en-US", false).NumberFormat;

            int sum = tv * 900 + dvd * 500 + mp3 * 700;

            if (sum > 10000) 
            {
                double total1 = (tv * 900 + dvd * 500 ) * 0.85 +mp3 * 700;

                System.Console.WriteLine("The total prive is " + total1.ToString("C", curr));
            }
            else if (sum < 10000) 
            {
                double total2 = (tv * 900 + dvd * 500 ) * 0.90 +mp3 * 700;

                System.Console.WriteLine("The total prive is " + total2.ToString("C", curr));
            }
            else
            {
                System.Console.WriteLine("The total prive is " + sum.ToString("C", curr));
            }
        }
    }
}