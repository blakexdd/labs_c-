using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_work
{
    public abstract class Person : IEmployee
    {
        public string surname { private set; get; } // persons surname
        public string date_of_birth { private set; get; } //  persons date of birth

        public Person(string surname, string date_of_birth)
        {
            this.surname = surname;
            this.date_of_birth = date_of_birth;
        }

        /* overriding string method */
        public override string ToString()
        {
            return $"Person:\nSurname: {surname}\nDate of birth: {date_of_birth}\n";
        }

        /* displaying info about person */
        virtual public void Display()
        {
            Console.WriteLine(this);
        }

        /* getting persons sellary */
        public abstract double GetSallary();

        /* getting age of person */
        public int GetAge()
        {
            /* splitting date of birth to day, mounth and year */
            string[] bd = date_of_birth.Split(new char[] { '.' });

            /* getting todays date */
            var now = DateTime.Today;
            return now.Year - Convert.ToInt32(bd[2]) - 1 +
                ((now.Month > Convert.ToInt32(bd[1]) || now.Month == Convert.ToInt32(bd[1]) && now.Day >= Convert.ToInt32(bd[0])) ? 1 : 0);
        }

        public virtual void require_additional_payment(double sum, Salary_center s)
        {

        }
    }
}
