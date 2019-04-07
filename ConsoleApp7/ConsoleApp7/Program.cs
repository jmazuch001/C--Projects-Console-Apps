using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 25;
            Console.WriteLine(myByte);

            sbyte mySbyte = -55;
            Console.WriteLine(mySbyte);

            int myInt = -1234987;
            Console.WriteLine(myInt);

            uint myUint = 84922;
            Console.WriteLine(myUint);

            short myShort = -32768;
            Console.WriteLine(myShort);

            ushort myUShort = 65535; // limit
            Console.WriteLine(myUShort);

            float myFloat = -31.1289f;
            Console.WriteLine(myFloat);

            double myDouble = -12.1231250;
            Console.WriteLine(myDouble);

            char myBuchstabe = 'A';
            Console.WriteLine(myBuchstabe);

            bool myBool = true;
            Console.WriteLine(myBool);

            string myText = "I control text";
            Console.WriteLine(myText);

            string numText = "15";

            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();
        }
    }
}
