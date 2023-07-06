using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_BasicPracticProgram
{
    public class ReverseWorldOfString
    {
        public void ReverseOnlyWorldOfString()
        {
            //Only world will be reverse
            string str = "Welcome to bridgelabs solution course";
            string[] rev = str.Split(' ');
            for (int i = rev.Length - 1; i >= 0; i--)
            {
                Console.Write(rev[i] + " ");
            }
        }
        //reverse whole string of char 
        public void StringReverseMethod(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
