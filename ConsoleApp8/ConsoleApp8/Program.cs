﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsC
{

    // Constants are immutable values which are known
    // at compile time and do not change for the life of the program

    class Program
    {

        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const int days = 365;
        const string birthday = "August 18, 1989"; 



        static void Main(string[] args)
        {

            // days = 366; notice how this will have an error due to the constant stated above
            Console.WriteLine("My birthday is always going to be {0}", birthday);
            Console.Read();

        }
    }
}
