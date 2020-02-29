using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    class Utils
    {
        /* Getting greater value method
         * ARGUMENTS:
         *   - two value we want to compare
         *      int a, int b
         * RETURNS:
         *   - biggest value
         *      (int)
         */
        public static int Greater(int a, int b)
        {
           /* checking what variable is bigger */
            if (a > b)
                return a;
            else
                return b;
        }

        /* swapping two values method
         * ARGUMENTS:
         *   - references to variables we wanna swap
         *       ref int a, ref int b
         * RETURNS:
         *   - None
         */
        public static void Swap(ref int a, ref int b)
        {
            /* swapping two variables using temproary */
            int temp = a;
            a = b;
            b = temp;
        }

        /* evaluating factorial method
         * ARGUMENTS:
         *   - number we want to evaluate factorial of 
         *     and out answer variable 
         *       int n, out int answer
         * RETURNS:
         *   - succeed of evaluating
         *      (bool)
         */
         public static bool Factorial(int n, out int answer)
         {
            /* initialzing variables */
            int k; // loop variable
            int f = 1; // factorial variable
            bool ok = true; // state of factorial variable

            /* trying to evaluate factorial */
            try
            {
                checked
                {
                    for (k = 2; k <= n; k++)
                        f *= k;
                }
            }
            /* catching exceptions */
            catch(Exception)
            {
                f = 0;
                ok = false;
            }

            /* assigning factorial to answer variable */
            answer = f;

            /* returning state */
            return ok;
         }

        /* checking if triangle exists
         * ARGUMENTS:
         *   - sides of the triangle
         *       double a, double b, double c
         * RETURNS:
         *   - if tringle exists or not
         *      (bool)
         */
        private static bool Is_exist(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else
                return false;
        }

        /* counting square of the triangle
         * ARGUMENTS:
         *   - sides of the triangle
         *       double a, double b, double c
         * RETURNS:
         *   - square of the trianlge
         *      (double)
         */
        public static double Square(double a, double b, double c)
        {
            /* checking if triangle exists */
            if (!Is_exist(a, b, c))
                return 0;

            /* initializing half of perimeter variable */
            double p = (a + b + c) / 2;

            /* initializing square variable */
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            /* returning square of the triangle */
            return S;
        }

        /* overloaded counting square of the triangle
         * ARGUMENTS:
         *   - side of the triangle
         *       double a
         * RETURNS:
         *   - square of the trianlge
         *      (double)
         */
        public static double Square(double a)
        {
            return Square(a, a, a);
        }

        /* evaluating roots of square equatioin
         * ARGUMENTS:
         *   - coefficients of equation
         * RETURNS:
         *   - state if roots found and if not
         *      (int)
         */
         public static int Roots(double a, double b, double c, ref double x1, ref double x2)
        {
            /* if a coefficien equals to 0, solving linear eqution */
            if (a == 0)
            {
                // in that case x1 is equals to x2
                x1 = x2 = -c / b;

                // returning value meaning that only 1 root occur
                return 0;
            }
            /* if descriminant equals to 0, there also x1 = x2*/
            else if (Math.Pow(b, 2) - 4 * a * c == 0)
            {
                /* solving equation */
                x1 = x2 = -b / (2 * a);

                // returning value meaning that only 1 root occur
                return 0;
            }
            /* if descrimimate less than 0, no roots for equation */
            else if (Math.Pow(b, 2) - 4 * a * c < 0)
                // returning value meaning roots doesnt exist
                return -1;
            /* overwise solving equasion and finding x1 and x2 */
            else
            {
                /* solving equation */
                x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

                // returning value meaning two roots exists
                return 1;
            }
        }
    }
}
