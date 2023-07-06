using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_BasicPracticProgram
{
    public class CountFrequenceOfElem
    {
        public void FrequencyOfElement(int[] arr, int n)
        {
            int visit = -1;
            int[] occur = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count = 1;  //becouse 1 time is visited every element
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        occur[j] = visit; // to ovoid counting of same element 
                    }
                }
                if (occur[i] != visit)
                {
                    occur[i] = count;
                }
            }
            for (int i = 0; i < occur.Length; i++)
            {
                if (occur[i] != visit)
                {
                    Console.WriteLine("element : " + arr[i] + " Occurence : " + occur[i]);
                }
            }
        }
    }
}
