using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_BasicPracticProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 15, 10, 3, 7, 4, 15 };
            CountDublicateElm count = new CountDublicateElm();
            count.CountMethod(arr);
        Console.ReadKey();
        }
    }
}
