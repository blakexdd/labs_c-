using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_work
{
    public class Salary_center
    {
        /* declarating all money, came to university */
        double all_money { set; get; }

        /* declarating all money for administrators */
        public double admin_money;

        /* declarating all money for lecturers */
        public double lectur_money;

        /* declarating all money for menegers */
        public double menegers_money;

        /* declarating all money for students */
        public double students_money;

        /* Class constructor */
        public Salary_center(double all_money)
        {
            this.all_money = all_money;
            admin_money = all_money * 0.4;
            lectur_money = all_money / 6;
            menegers_money = all_money / 7;
            students_money = all_money / 8;
        }
    }
}
