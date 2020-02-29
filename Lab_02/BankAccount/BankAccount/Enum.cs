using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    /* Bank account type enumeration */
    public enum AccountType
    {
        Checking,
        Deposit
    }

    class Enum
    {
        static void Main(string[] args)
        {
            /* declarating Account type variables */
            AccountType goldAccount;
            AccountType platinumAccount;

            /* assigning values to variables */
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            /* printing information about account types */
            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);

            /* to keep console awake */
            Console.ReadLine();
        }
    }
}
