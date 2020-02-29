using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructType
{
    /* Account Type enumeration */
    public enum AccountType { Checking, Deposit }

    /* Bank Account struct */
    public struct BankAccount
    {
        public long accNo; // account number
        public decimal accBal; // account ballance
        public AccountType accType; // account type
    }

    /* Distance struct */
    public struct Distance
    {
        /* Declarating class variables */
        public int feets;
        public double inches;

        /* Distance countructor
         * ARGUMENTS:
         *   - distance in feets and iches
         *       double f, double inch
         * RETURNS:
         *   - None
         */
        public Distance(int f, double inch)
        {
            /* initializing variables */
            feets = f;
            inches = inch;
        }

        /* Overloaded plus operator for distance class
         * ARGUMENTS:
         *   - distance object to pluss
         *      Distance
         * RETURNS:
         *   - resulted distance object
         *      Distance
         */
        public static Distance operator+(Distance d1, Distance d2)
        {
            /* initializing temproary feets and inches */
            int temp_feets = d1.feets + d2.feets;
            double temp_inches = d1.inches + d2.inches;

            /* calculating real feets and inches */
            int real_feets = temp_feets + (int)(temp_inches / 12);
            double real_inches = temp_inches % 12;

            /* returning resulted distance */
            return new Distance(real_feets, real_inches);
        }
    }

    class Struct
    {
        static void Main(string[] args)
        {
            /* declarating bank account variable */
            BankAccount goldAccount;

            /* assigning values to Bank account variable */
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            //goldAccount.accNo = 123;
            Console.Write("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());

            /* printing information about account */
            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}: ", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}: ", goldAccount.accType);
            Console.WriteLine("Acct Balance ${0}: ", goldAccount.accBal);

            /* declarating distance variables */
            Distance d1;
            Distance d2;
            Distance res;

            /* getting info about distances */
            Console.Write("Enter first distance feets: ");
            d1.feets = Int32.Parse(Console.ReadLine());
            Console.Write("Enter first distance inches: ");
            d1.inches = double.Parse(Console.ReadLine());
            Console.Write("Enter second distance feets: ");
            d2.feets = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second distance inches: ");
            d2.inches = double.Parse(Console.ReadLine());

            /* counting sum of two distance variables */
            res = d1 + d2;

            /* printing sum of two distances */
            Console.WriteLine("{0}'-{1}\"", res.feets, res.inches);

            /* to keep console awake */
            Console.ReadLine();
        }
    }
}
