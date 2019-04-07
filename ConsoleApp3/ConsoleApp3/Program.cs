using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // examples of initialized variables
            int num1 = 15;
            int num2 = 1;
            // uninitialized variable example
            // declared but unused
            int num3;

            // can declare multiple variables in one line 
            // int num3, num4, num5;

            int sum = num1 + num2;


            double d1 = 3.111;
            double d2 = 6.55;
            double sumD = d1 + d2;
            // You cannot divide a double by an int[eger]
            // this will initialize the uninitialized var above
            // num3 = 49;

            // FLOATS
            // float f1 = 6.55; this will not work - you must add an F to initialize it
            float f1 = 6.55F; // not as precise, but half as big as data storage required



            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumD);
            Console.Read();
        }
    }
}
