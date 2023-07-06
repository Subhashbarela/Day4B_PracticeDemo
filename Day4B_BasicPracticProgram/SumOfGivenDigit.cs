using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_BasicPracticProgram
{
    public class SumOfGivenDigit
    {
        public void SumOfDigit(int num)
        {
            int temp = num;
            int rem, sum = 0;

            while (temp > 0)
            {
                rem = temp % 10;
                sum += rem;
                temp = temp / 10;
            }
            Console.WriteLine("Sum of {0} number is: {1}", num, sum);
        }
    }
}
