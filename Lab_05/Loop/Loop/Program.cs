using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* initializing array */
            int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };
            
            /* printing elements */
            for (int i = 0; i < myArray.Length; i++)
            {
                /* changing all even values to 0 */
                if (myArray[i] % 2 == 0)
                    myArray[i] = 0;
            
                /* printing elements */
                Console.Write(myArray[i] + " ");
            }

            /* initializing array */
            int[] MyArray;

            /* asking person to enter size of array */
            Console.Write("\nEnter size of array: ");

            /* getting size of array */
            int n = Convert.ToInt32(Console.ReadLine());

            /* allocating memory for arrays variables */
            MyArray = new int[n];

            /* initializing arrays values */
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write($"a[{i}]="); // asking person to enter a[i] value 
                MyArray[i] = int.Parse(Console.ReadLine()); // assigning element to array
            }

            /* printing values */
            foreach (int i in MyArray)
                Console.Write($"{i} ");



            /* to keep console awake */
            Console.ReadLine();
        }
    }
}
