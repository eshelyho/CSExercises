using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            //string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = new int[5] { 63, 29, 75, 82, 55 };

            int min, temp;

            for (int i = 0; i < mark.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < mark.Length; j++)
                {
                    if (mark[j] < mark[min])
                    {
                        min = j;
                    }
                    temp = mark[i];
                    mark[i] = mark[min];
                    mark[min] = temp;
                }
            }


            Array.Reverse(mark);
            foreach (int value in mark)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

        }
    }
}

