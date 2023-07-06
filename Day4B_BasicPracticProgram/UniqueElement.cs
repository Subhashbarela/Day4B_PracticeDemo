using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_BasicPracticProgram
{
    public class UniqueElement
    {
        public void UniqueElementMethod(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])  //if we get dublicate element 
                    {
                        for (int k = j; k < n - 1; k++) // traversing from dublicate element
                        {
                            arr[k] = arr[k + 1]; //shifting the element to remove dublicate element
                        }
                        n--;
                        //j--;
                    }
                }
            }
            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }       
    }
}
