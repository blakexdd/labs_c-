using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_work
{
    class Administrator : Person, IEmployee
    {
        /* administrators laboratory */
        public string laboratory { private set; get; }
        public double money = 0;

        /* administrator class constructor */
        public Administrator(string name, string date_of_birth, string laboratory) : base(name, date_of_birth)
        {
            this.laboratory = laboratory;
        }

        /* displaying information about person */
        new public void Display()
        {
            base.Display();
            Console.WriteLine($"Laboratory: {laboratory}");
        }

        /* overriting getting sallary method */
        public override double GetSallary()
        {
            int age = GetAge();

            return age * 25000;
        }

        /* requiring momey function */
        public void require_additional_payment(double sum, Salary_center s)
        {
            if (sum < s.admin_money)
                money += sum;
            else
                Console.WriteLine($"No additional money for administrators this mounth");
        }

    }
}
