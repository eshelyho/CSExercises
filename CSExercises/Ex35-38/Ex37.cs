using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;


namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a pharse or sentence.");
            string pharse = Console.ReadLine();


            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture; //build culture propert
            TextInfo textInfo = cultureInfo.TextInfo; //build textinfo object

            System.Console.WriteLine(textInfo.ToTitleCase(pharse));



        }
    }
}
