using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_BasicPracticProgram
{
    public class MaxAndMinValue
    {
        public void MaxiValue(int[] arr, int n)
        {
            int i;
            int max = arr[0];
            for (i = 0; i < n - 1; i++)
            {
                if (arr[i + 1] > max)
                {
                    max = arr[i + 1];
                }
            }
            Console.WriteLine("Maximun  Element is: :" + max);
        }
        public void MinValue(int[] arr, int size)
        {
            int i;
            int min = arr[0];
            for (i = 0; i < size - 1; i++)
            {
                if (arr[i + 1] < min)
                {
                    min = arr[i + 1];
                }
            }
            Console.WriteLine("Minmum Element is: " + min);
        }
    }
}
