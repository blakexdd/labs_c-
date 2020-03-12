using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Initializing list of persons */
            List<Person> people_from_uni = new List<Person>();


            /* Adding persons to the list */
            people_from_uni.Add(new Student("Vladimir", "06.08.2001", "TINT", "K3120"));
            people_from_uni.Add(new Lecturer("Andrey", "12.02.1965", "FIKT", "Decan", 20));
            people_from_uni.Add(new Meneger("Fedor", "23.01.1992", "FIKT", "sales meneger"));
            people_from_uni.Add(new Administrator("Alyona", "15.04.1994", "Vyazemski"));

            /* displaying information about users */
            foreach (Person p in people_from_uni)
            {
                p.Display();
                Console.WriteLine("=========");
            }

            /* Reading range of years */
            Console.Write("Enter lower bound of years: ");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter upper bound of years: ");
            int upper = Convert.ToInt32(Console.ReadLine());

            /* comparing numbers in range */
            foreach (Person p in people_from_uni)
            {
                int p_age = p.GetAge();

                if (lower <= p_age && p_age <= upper)
                    p.Display();
            }

            /* Creating additional money instance */
            Salary_center s = new Salary_center(50000);

            /* asking for money */
            people_from_uni[0].require_additional_payment(40393, s);

            Console.Read();
        }
    }
}
