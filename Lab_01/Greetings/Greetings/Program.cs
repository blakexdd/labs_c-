using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greetings
{
    class Greeter
    {
        static void Main(string[] args)
        {
            /* declarating variables */
            string myName; // my name variable

            /* asking user to enter name */
            Console.WriteLine("Please enter your name");

            /* reading name of the person */
            myName = Console.ReadLine();

            /* printing greeting to the console */
            Console.WriteLine("Hello, {0}", myName);

            /* to keep console awake */
            Console.ReadLine();
        }
    }
}
