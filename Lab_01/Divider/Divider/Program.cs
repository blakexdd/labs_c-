using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            /* trying execute code above */
            try
            {
                /* asking user to enter first integer number */
                Console.WriteLine("Please enter the first integer");

                /* reading first integer in string variable */
                string temp = Console.ReadLine();

                /* converting string variable into integer number */
                int i = Int32.Parse(temp);

                /* asking user to enter second integer number */
                Console.WriteLine("Please enter the second number");

                /* reading second integer to string variable */
                temp = Console.ReadLine();

                /* converting string variable into integer number */
                int j = Int32.Parse(temp);

                /* initializing variable as result of division of entered values */
                int k = i / j;

                /* printing out resulted variable */
                Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);
            }
            /* catching format exceptions */
            catch(FormatException e)
            {
                Console.WriteLine("An format exception was thrown: {0}", e.Message);
            }
            /* catching division by zero */
            catch(DivideByZeroException e)
            {
                Console.WriteLine("An DivideByZero exception was thrown: {0}",
                    e.Message);
            }
            /* catching exception if something went wrong */
            catch(Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }

            /* asking user to enter perimeter of the triangle */
            Console.WriteLine("Enter perimeter of the triangle");

            /* reading perimeter of the triangle and assigning half of it to p var */
            double p = Double.Parse(Console.ReadLine()) / 2;

            /* evaluating square of the triangle */
            double S = Math.Sqrt(p * Math.Pow((p - 2 / 3 * p), 3));

            /* printing results out */
            Console.WriteLine("Сторона    Площадь");
            Console.WriteLine("{0:0.00}       {1:0.00}", 2 * p / 3, S);

            /* to keep console awake */
            Console.ReadLine();
        }
    }
}
