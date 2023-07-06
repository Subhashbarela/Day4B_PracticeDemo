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
            int len=arr.Length;
            Console.WriteLine("1: Count Dublicacy in Array \n2: Print Unique Element \n3: Find Frequency ");
            Console.WriteLine("Enter youe choice from Above");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        CountDublicateElm count = new CountDublicateElm();
                        count.CountMethod(arr);
                        break;
                    }
                    case 2:
                    {
                        UniqueElement unique = new UniqueElement();
                        unique.UniqueElementMethod(arr, len);
                        break;
                    } 
                case 3:
                    {
                        CountFrequenceOfElem frequency = new CountFrequenceOfElem();
                        frequency.FrequencyOfElement(arr, len);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("insert valid input ..!");
                        break;
                    }
            }
            
        Console.ReadKey();
        }
    }
}
