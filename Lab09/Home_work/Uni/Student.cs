using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_work
{
    class Student : Person, IEmployee
    {
        /* initializing lecturers variables */
        public string faculty { private set; get; }
        public string group { private set; get; }
        public double money = 0;

        /* administrator class constructor */
        public Student(string name, string date_of_birth, string faculty, string group) : base(name, date_of_birth)
        {
            this.faculty = faculty;
            this.group = group;
        }

        /* displaying information about lecturer */
        new public void Display()
        {
            base.Display();
            Console.WriteLine($"Faculty: {faculty}\nGroup: {group}");
        }

        /* overriting getting sallary method */
        public override double GetSallary()
        {
            int age = GetAge();

            return age * 10000;
        }

        /* requiring momey function */
        public void require_additional_payment(double sum, Salary_center s)
        {
            if (sum < s.students_money)
                money += sum;
            else
                Console.WriteLine($"No additional money for students this mounth");
        }
    }
}
