using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loop
{
    class Program
    {
        class Dot
        {
            /* declarating class variables */
            public double x; // x coordinate 
            public double y;  // y coordinate 

            /* Dot constructor 
             * ARGUMENTS:
             *   - x, y coordinates of the dot
             *      int x, int y
             * RETURNS:
             *   - None
             */
            public Dot(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            /* getting data from user */
            Console.Write("n = "); // asking person to enter n
            int n = int.Parse(Console.ReadLine()); // assigning values to int variable
   
            /* printting out odd numbers seperated by space using while */
            Console.Write("\nwhile: \t\t"); // friendly loop interface
            int i = 1; // initializing cycle counter variable 
            
            while (i <= n)
            {
                Console.Write(" " + i); // printing space and value
                i += 2; // adding 2 to counter value
            }
   
            /* printing out odd numbers separated by space using do while */
            Console.Write("\ndo while: \t");
            i = 1; // reseting cycle counter variable
   
            do
            {
                Console.Write(" " + i); // printing space and value
                i += 2;
            } while (i <= n);
   
            /* printing out odd numbers separated by space using for */
            Console.Write("\nfor: \t\t");
   
            for (int j = 1; j <= n; j += 2)
                Console.Write(" " + j);
   
            /* initializing variables */
            double x1 = 2; // start value of range
            double x2 = 3; // end value of range
            double x = x1; // function arg
            double y; // function value
   
            /* printing header of the table */
            Console.WriteLine("\nX\t\ty");
   
            /* implementing functing y = sin(x) */
            do
            {
                y = Math.Sin(x); // evaluating y for current x
                Console.WriteLine("{0:0.00}\t\t{1:0.00}", x, y); // printing out arg and value of function
   
                x += 0.01; // making a baby step right
            } while (x <= x2);
   
            /* getting users data */
            Console.Write("Enter first value: "); // asing person to enter first value
            int a = int.Parse(Console.ReadLine()); // reading first value
            Console.Write("Enter second value: "); // asking person to enter second value
            int b = int.Parse(Console.ReadLine()); // reading second value
            int temp = a; // initializing temproary value
   
            /* implementing Euclidean algorithm using while */
            while (temp != b)
            {
                a = temp;
                
                /* swapping values, so in a variable 
                   maximum of a and b*/
                if (a < b)
                {
                    /* swapping values */
                    temp = a;
                    a = b;
                    b = temp;
                }
   
                /* updating temproary value */
                temp = a - b;
   
                /* updating second variable */
                a = b;
            }
   
            /* implementing Euclidean algorithm using do while */
            do
            {
                if (temp == b)
                    break;
   
                a = temp;
   
                /* swapping values, so in a variable 
                   maximum of a and b*/
                if (a < b)
                {
                    /* swapping values */
                    temp = a;
                    a = b;
                    b = temp;
                }
   
                /* updating temproary value */
                temp = a - b;
   
                /* updating second variable */
                a = b;
   
            } while (temp != b);
   
            /* printing out results of algorithm */
            Console.WriteLine("Result of algorithm (while) is: {0}", temp);
   
            Console.WriteLine("Result of algorithm (do while) is: {0}", temp);
   
            /* getting users data */
            Console.Write("k = "); // asking person to enter k
            int k = int.Parse(Console.ReadLine()); // reading k in int variale
            Console.Write("m = "); // asking person to enter m
            int m = int.Parse(Console.ReadLine()); // reading m in int variable
   
            /* initializing summator variable */
            int sum = 0;
   
            /* counting sum from 1 to k and from m to 100 */
            for (i = 1; i <= 100; i++)
            {
                /* skipping values from k to m */
                if (i > k && i < m)
                    continue;
                
                /* evaluating sum */
                sum += i;
            }
   
            /* printing out sum */
            Console.WriteLine("Sum = {0}", sum);

            /* asking person how many time he/she wants to shoot */
            Console.Write("How many times do you wanna shoot? \n");
            int shoots_number = int.Parse(Console.ReadLine()); // reading number of shots in int variable

            /* initializing center of aim and bias randomly */
            Random rand = new Random(); // initializing random variable
            double center_x = ((rand.Next(0, 20) - 20) / 2); // getting center x coordinates from -10 to 10 
            double center_y = ((rand.Next(0, 20) - 20) / 2); // getting center y coordinates from -10 to 10 
            double x_bias = ((rand.Next(0, 2) - 2) / 2); // getting x bias from -1 to 1
            double y_bias = ((rand.Next(0, 2) - 2) / 2); // getting y bias from -1 to 1

            /* initializing array for entered x, y coordinates */
            Dictionary<int, Dot> coordinates = new Dictionary<int, Dot>(shoots_number);

            /* gettting users shots*/
            for (i = 0; i < shoots_number; i++)
            {

                Console.Write("x = "); // asking person to enter x coordinate
                double temp_x = double.Parse(Console.ReadLine()); // assigning x value to 0 component of array
                Console.Write("y = "); // asking persin to enter y coordinate
                double temp_y = double.Parse(Console.ReadLine()); // assignign y value to 1 component of array

                /* adding bias to x and y coordinates */
                temp_x += x_bias;
                temp_y += y_bias;

                /* adding values to dictionary */
                coordinates.Add(i, new Dot(temp_x, temp_y));
            }


            /* initializing score variables */
            int score = 0;

            /* going through all x, y pairs and calculating final score */
            foreach(KeyValuePair<int, Dot> keyValue in coordinates)
            {
                if (Math.Pow(keyValue.Value.x - center_x, 2) +
                    Math.Pow(keyValue.Value.y - center_y, 2) < 1)
                    score += 10;
                else if (Math.Pow(keyValue.Value.x - center_x, 2) +
                    Math.Pow(keyValue.Value.y - center_y, 2) < 4)
                    score += 5;
                else if (Math.Pow(keyValue.Value.x - center_x, 2) +
                    Math.Pow(keyValue.Value.y - center_y, 2) < 9)
                    score += 1;
                else
                    score += 0;
            }

            /* printing final score */
            Console.WriteLine("Final score is {0}", score);

            /* to keep console awake */
            Console.ReadLine();
        }
    }
}
