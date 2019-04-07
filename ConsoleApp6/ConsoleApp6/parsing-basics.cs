using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // you have a string that is a number
            string myString = "15";
            // let's say you want to use it as an actual number
            string mySecondString = "19";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;

            string result = myString + mySecondString;

            Console.WriteLine(resultInt);
            Console.Read();

            // you can also parse doubles into strings
        }
    }
}
