using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            int num = 913274577;
            long bigNum = num;

            float myFloat = 6.99F;
            double myNewDouble = myFloat;

            // explicit conversion
            double myDouble = 13.99;
            int myInt;

            // cast double to int
            myInt = (int)myDouble;

            // typeConversion
            string myString = myDouble.ToString();
            // num.ToString...
            string myFloatString = myFloat.ToString();

            bool sunIsShining = true; // can be T/F

            string myBoolString = sunIsShining.ToString();


            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}
