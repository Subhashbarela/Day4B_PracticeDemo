using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_BasicPracticProgram
{
    public class SumOfRowInMatrix
    {
        public void Matrix()
        {
            int[,] arr = { { 2, 4 }, { 4, 7 } };
            int sum = 0;
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                sum = 0;
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    sum += arr[row, col];
                }
                Console.WriteLine("Sum of row[{0}]: {1}", (row + 1), sum);
            }
        }
    }
}
