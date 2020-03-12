using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            /* initializing matricies */
            //int[,] a = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            //int[,] b = new int[2, 2] { { 5, 6 }, { 7, 8 } };
            //int[,] result = new int[2, 2]
            //    { {a[0,0] * b[0, 0] + a[0, 1] * b[1, 0], a[0,0] * b[0,1] + a[0,1] * b[1,1]},
            //      { a[1,0] * b[0,0] + a[1,1]  *b[1,0], a[1,0] * b[0,1] + a[1,1] * b[1,1] } };
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[] task;

            /* getting users data */
            Console.WriteLine("Enter first arrays values: "); // asking to enter first arrays values
            Input(a); // getting first arrays values from user 
            Console.WriteLine("Enter second arrays values: "); // asking to enter second arrays values
            Input(b); // getting second arrays values from user

            /* initializing resulted array as multi of a and b*/
            int[,] result = Multiply(a, b);

            /* printing out the result */
            Output(result);

            /* getting users data */
            Console.Write("Enter size of array: "); // asking to enter size of array
            int size = Convert.ToInt32(Console.ReadLine()); // reading size of array
            Console.WriteLine("Enter arrays values"); // asking to write arrays values
            task = new int[size]; // allocation memory for array
            Input(task); // reading arrays values

            /* printing out tests */
            Console.WriteLine($"Sum of arrays elemets: {Sum(task)}");
            Console.WriteLine($"Average of arrays elemets: {Average(task)}");
            Console.WriteLine($"Negative sum of arrays elemets: {N_sum(task)}");
            Console.WriteLine($"Positive sum of arrays elemets: {P_sum(task)}");
            Console.WriteLine($"Sum of arrays even elemets: {Even_sum(task)}");
            Console.WriteLine($"Sum of arrays odd elemets: {Odd_sum(task)}");
            Console.WriteLine($"Argmax: {Argmax(task)}");
            Console.WriteLine($"Argmin: {Argmin(task)}");
            Console.WriteLine($"Product of element between min and max: {P_range(task)}");

            /* to keep console awake */
            Console.ReadLine();
        }

        private static int Sum(int[] a)
        {
            /* initializing sum varaible */
            int sum = 0;

            /* going through elements and counting sum */
            foreach (int i in a)
                sum += i;

            /* returning sum */
            return sum;
        }

        private static double Average(int[] a)
        {
            return Sum(a) / (double)a.Length;
        }

        private static int N_sum(int[] a)
        {
            /* initializnig sum variable */
            int sum = 0;

            /* going through elements and counting negative elements */
            foreach (int i in a)
                sum += i < 0 ? i : 0;

            /* returning sum */
            return sum;
        }

        private static int P_sum(int[] a)
        {
            return Sum(a) - N_sum(a);
        }

        private static int Odd_sum(int[] a)
        {
            /* initializnig sum variable */
            int sum = 0;

            /* going through elements and counting negative elements */
            foreach (int i in a)
                sum += i % 2 != 0 ? i : 0;

            /* returning sum */
            return sum;
        }

        private static int Even_sum(int[] a)
        {
            return Sum(a) - Odd_sum(a);
        }

        private static int Argmax(int[] a)
        {
            return a.ToList().IndexOf(a.Max());
        }

        private static int Argmin(int[] a)
        {
            return a.ToList().IndexOf(a.Min());
        }

        private static int P_range(int[] a)
        {
            /* initializing product variable */
            int p = 1;

            /* counting product of numbers between max and min variable */
            for (int i = Math.Min(Argmin(a), Argmax(a)) + 1;
                i < Math.Max(Argmax(a), Argmin(a)); i++)
                p *= a[i];

            /* returning p*/
            return p;
        }

        private static void Input(int[] a)
        {
            /* reading arrays elements */
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{i} element: "); // asking to enter i element
                a[i] = Convert.ToInt32(Console.ReadLine()); // reading arrays value
            }
        }

        private static void Input(int[,] a)
        {
            /* going through rows */
            for (int r = 0; r < a.GetLength(0); r++)
                /* going through columns */
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    /* getting users data */
                    Console.Write($"Enter value for [{r},{c}] : "); // asking to enter particular item
                    a[r, c] = Convert.ToInt32(Console.ReadLine()); // reading value 
                }

            /* printing empty line */
            Console.WriteLine();
        }

        private static int[,] Multiply(int[,] a, int[,] b)
        {
            /* initializing temproary array */
            int[,] result = new int[2, 2];

            /* implementing matrix multiplication */
            //result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            //result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            //result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            //result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];
            for (int r = 0; r < result.GetLength(0); r++)
                for (int c = 0; c < result.GetLength(1); c++)
                    result[r, c] = a[r, 0] * b[0, c] + a[r, 1] * b[1, c];

            /* returning resulted matrix */
            return result;
        }

        private static void Output(int[,] result)
        {
            /* going through all elemnts and printing them as a table */
            for (int r = 0; r < result.GetLength(0); r++)
            {
                /* printing row */
                for (int c = 0; c < result.GetLength(1); c++)
                    Console.Write($"{result[r, c]} ");

                /* printing empty line */
                Console.WriteLine();
            }
        }
    }
}
