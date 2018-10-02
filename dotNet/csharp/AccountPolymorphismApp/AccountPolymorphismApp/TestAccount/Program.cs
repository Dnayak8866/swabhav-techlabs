using System;
using System.Collections.Generic;
using System.Text;

namespace AccountPolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account sa = new SavingAccount(111, "Chandan", 500);
            Account ca = new CurrentAccount(222, "Dharmesh", 500);
            sa.DepositeAmount(500);
            sa.Withdraw(1000);

            PrintDetails(sa);

            Console.WriteLine("-----------------------------------");
            ca.Withdraw(5000);
            PrintDetails(ca);
        }

        private static void PrintDetails(Account acnt)
        {
            Console.WriteLine("Inside Print...");
            Console.WriteLine(acnt);  
        }
    }
}
