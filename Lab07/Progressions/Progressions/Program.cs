using System;

namespace Progressions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* initializing class variables */
            GeometricProgression g = new GeometricProgression(1, 2);
            ArithmeticProgression a = new ArithmeticProgression(1, 2);

            /* getting elements */
            Console.WriteLine($"4th elemnt of geometric progresion is {g.GetElement(4)}");
            Console.WriteLine($"4th elemnt of arithmetic progresion is {a.GetElement(4)}");
        }
    }
}
