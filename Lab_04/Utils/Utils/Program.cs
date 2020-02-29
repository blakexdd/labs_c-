using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            /* initializing variables */
            int x;
            int y;

            /* getting users data */
            Console.WriteLine("Enter first number: "); // asking preson to enter first value
            x = int.Parse(Console.ReadLine()); // assigning first value to int variable
            Console.WriteLine("Enter second number: "); // asking preson to enter second value
            y = int.Parse(Console.ReadLine()); // assigning second value to int variable

            /* getting maximum value out of two entered */
            int greater = Utils.Greater(x, y);

            /* printing maximum of two numbers */
            Console.WriteLine("Greater number of {0} and {1} is {2} ", x, y, greater);

            /* printing old variables information */
            Console.WriteLine("Before swap: \t" + x + " " + y);

            /* swapping x and y */
            Utils.Swap(ref x, ref y);

            /* printing new variables information */
            Console.WriteLine("After swap: \t" + x + " " + y);

            /* initializing variables */
            int f; // factorial variable 
            bool ok; // state variable 

            /* getting users data */
            Console.WriteLine("Number for factorial: "); // asking to enter number for factorail
            x = int.Parse(Console.ReadLine());

            /* evaluating factorial */
            ok = Utils.Factorial(x, out f);

            /* checking if evaluating factorial was successful */
            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");

            /* getting users data */
            Console.WriteLine("Enter type of triangle\n1 - equal sides\n2 - non equal sides"); // asking person to enter type of the triangle
            int choise = int.Parse(Console.ReadLine()); // assigning choise to int variable

            /* declarating square variable */
            double square;

            /* checking for type of trianlge */
            if (choise == 1)
            {
                /* getting users data */
                Console.Write("Enter side of the triangle: "); // asking to enter side of triangle
                double side = double.Parse(Console.ReadLine()); // assigning side to double variable

                /* evaluating square of the triangle */
                square = Utils.Square(side);
            }
            else
            {
                /* getting users data */
                Console.Write("Enter len of first side: "); // asking persin to enter first side
                double side_1 = double.Parse(Console.ReadLine()); // assigning first side length to double variable
                Console.Write("Enter len of second side: "); // asking persin to enter second side
                double side_2 = double.Parse(Console.ReadLine()); // assigning second side length to double variable
                Console.Write("Enter len of third side: "); // asking persin to enter third side
                double side_3 = double.Parse(Console.ReadLine()); // assigning third side length to double variable

                /* evaluating square of the triangle */
                square = Utils.Square(side_1, side_2, side_3);
            }

            /* printing square */
            Console.WriteLine("Squre is {0}", square);

            /* getting users data */
            Console.Write("Enter a coefficient: "); // asking person to enter a coefficient
            double a = Convert.ToDouble(Console.ReadLine()); // assigning a to double variable
            Console.Write("Enter b coefficient: "); // asking person to enter b coefficient
            double b = Convert.ToDouble(Console.ReadLine()); // assigning b to double variable
            Console.Write("Enter c coefficient: "); // asking person to enter c coefficient
            double c = Convert.ToDouble(Console.ReadLine()); // assigning c to double variable

            /* initializing roots variables */
            double x1 = 0; // first root variable
            double x2 = 0; // second root variable
            int state; // initializing state of operation

            /* counting roots x1, x2 using Utils built in method */
            state = Utils.Roots(a, b, c, ref x1, ref x2);

            /* checking operating state */
            if (state == -1)
                Console.WriteLine($"Корней уравнения с коэффициентами a = {a}, " +
                    $"b = {b}, c = {c} нет");
            else if (state == 0)
                Console.WriteLine($"Корень уравнения с коэффициентами a = {a}, " +
                    $"b = {b}, c = {c} один x1 = x2 = {x1}");
            else
                Console.WriteLine($"Корни уравнения с коэффициентами a = {a}, " +
                    $"b = {b}, c = {c} равны x1 = {x1}, x2 = {x2}");

            /* to keep console awake */
            Console.ReadLine();
        }
    }
}
