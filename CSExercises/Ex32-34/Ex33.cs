using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[]iss=new int[20]{86,35,41,49,59,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79};
            int min, temp;
            
            for(int i=0; i<iss.Length-1;i++)
            {
                min = i;

                for (int j=i+1; j<iss.Length;j++)
                {
                    if (iss[j]<iss[min])
                    {
                        temp = iss[i];
                        iss[i] = iss[j];
                        iss[j] = temp;
                    }

                }
            }
 
            
            Array.Reverse(iss);
            foreach (int value in iss)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
           
            
        }
    }
}
