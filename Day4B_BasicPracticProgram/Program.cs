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
            Console.WriteLine("1: Count Dublicacy in Array \n2: Print Unique Element \n3: Find Frequency \n4: Max And Min Value" +
                "\n5: Triangle pattern \n6: Square pattern \n7: Reverse Class");
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
                case 4:
                    {
                        MaxAndMinValue minmax = new MaxAndMinValue();
                        minmax.MaxiValue(arr, len);
                        minmax.MinValue(arr, len);
                        break;
                    }
                    case 5:
                    {
                        TrianglePatternProgram triangle = new TrianglePatternProgram();
                        triangle.PatternDemo();
                        break;
                    } 
                case 6:
                    {
                        SquarePatternClass square = new SquarePatternClass();
                        square.SquarePattern(5);
                        break;
                    }
                case 7:
                    {
                        ReverseWorldOfString reverse = new ReverseWorldOfString();
                        //reverse.ReverseOnlyWorldOfString();
                        reverse.StringReverseMethod("bridgelabs");
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
