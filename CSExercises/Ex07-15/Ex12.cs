﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the dustance traveled.");
            String dt1 = System.Console.ReadLine();
            double dt = System.Convert.ToDouble(dt1);
            double total = Math.Round((2.40 + dt * 0.4), 1);

            System.Console.WriteLine("The total fare is {0:0.00}", total);

        }
    }
}
