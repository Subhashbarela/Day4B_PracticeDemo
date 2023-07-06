using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_BasicPracticProgram
{
    public class CountDublicateElm
    { 
        public void CountMethod(int[] arr1)
        {
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]+" ");
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        count++;
                        // break;
                    }
                }
            }
            Console.WriteLine("\nTotal number of dublicate element is: " + count);           
        }
    }
}
