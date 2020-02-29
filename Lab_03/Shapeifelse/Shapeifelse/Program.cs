using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapeifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            /* getting users data */
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            float y = float.Parse(Console.ReadLine());

            /* checking if dot is in the area */
            if (x * x + y * y < 9 && y > 0)
                Console.WriteLine("Внутри");
            else if (x * x + y * y > 9 || y < 0)
                Console.WriteLine("Вне");
            else
                Console.WriteLine("На границе");

            /* initializing values for switch clause */
            bool ok = true;
            double res = 0;

            /* getting data from user */
            Console.Write("Enter first number: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter opperation: ");
            char op = char.Parse(Console.ReadLine());

            /* implementing switch clause */
            switch (op)
            {
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                case '*':
                    res = a * b;
                    break;
                case '/':
                    res = a / b;
                    break;
                case ':':
                    res = a / b;
                    break;
                default:
                    ok = false;
                    break;
            }

            /* checking if we calculated the result */
            if (ok)
                Console.WriteLine("{0} {1} {2} = {3}", a, op, b, res);
            else
                Console.WriteLine("Опреация не определена");

            /* getting data from user */
            Console.Write("Enter year: "); // asking person to enter year he/she wants to test
            int year = Int32.Parse(Console.ReadLine()); // reading year in year variable

            /* checking for type of the year */
            if (year % 4 == 0 && year % 100 != 0)
                Console.WriteLine("YES");
            else if (year % 400 == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("No");
          

            /* to keep console awake */
            Console.ReadLine();
        }
    }
}
