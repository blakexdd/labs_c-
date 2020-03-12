using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_work
{
    class Lecturer : Person, IEmployee
    {
        /* initializing lecturers variables */
        public string faculty { private set; get; }
        public string post { private set; get; }
        public int standing { private set; get; }
        public double money = 0;

        /* administrator class constructor */
        public Lecturer(string name, string date_of_birth, string faculty, string post, int standing) : base(name, date_of_birth)
        {
            this.faculty = faculty;
            this.post = post;
            this.standing = standing;
        }

        /* displaying information about lecturer */
        new public void Display()
        {
            base.Display();
            Console.WriteLine($"Faculty: {faculty}\nPost: {post}\nStanding: {standing}");
        }

        /* overriting getting sallary method */
        public override double GetSallary() => standing * 50000;

        /* requiring momey function */
        public void require_additional_payment(double sum, Salary_center s)
        {
            if (sum < s.lectur_money)
                money += sum;
            else
                Console.WriteLine($"No additional money for lecturers this mounth");
        }
    }
}
