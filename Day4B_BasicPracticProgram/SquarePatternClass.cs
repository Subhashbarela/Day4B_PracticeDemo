using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_BasicPracticProgram
{
    public class SquarePatternClass
    {
        public void SquarePattern(int len)
        {

            for (int i = 1; i <= len; i++)
            {
                for (int j = 1; j <= len; j++)
                {
                    if (i == 1 || i == len || j == 1 || j == len)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }                   
                }
                Console.WriteLine();
            }
        }
    }
}
