using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> bank = new List<Account>();
            bank.Add(new Account { AccntID = 111, AccountName = "dharmesh", AccountBalance = 50000 });
            bank.Add(new Account { AccntID = 222, AccountName = "chandan", AccountBalance = 60000 });
            bank.Add(new Account { AccntID = 333, AccountName = "abhi", AccountBalance = 70000 });

            IEnumerable<Account> allAccounts = bank.Select((a) => a);
            IEnumerable<Account> allAccountNamesWithAscend = allAccounts.OrderBy((a) => a.AccountName);

            var accountWithNameBalance = bank.Select((a) => new { a.AccountName, a.AccountBalance });
         
            var maxbalanceAmount = accountWithNameBalance.Max((a) => a.AccountBalance);
            Console.WriteLine("Maximum Balance in a account :" + maxbalanceAmount);
          

            var accounts = bank.Select((a) => a).Where((a) => a.AccountBalance >= maxbalanceAmount);
            foreach (var item in accounts)
            {
                Console.WriteLine("AccountName with MaxBal :" + item.AccountName + "\n" +
                    "Account Balance :" + item.AccountBalance);
            }

            Console.WriteLine("-------------------------------------------------");
            var account =from a in bank
            where a.AccountBalance > 50000
            select a;
            Console.WriteLine("Using Query Syntax....");
            foreach (var item in account)
            {
                Console.WriteLine("Account Name:"+item.AccountName
                    +"\nAccountBalance :"+item.AccountBalance);
            }


            Console.WriteLine("-------------------------------------------------");
            foreach (var item in accountWithNameBalance)
            {
                Console.WriteLine("Account name :" + item.AccountName + "\n" + "Balance :" + item.AccountBalance);
            }

            Console.WriteLine("-------------------------------------------------");
            foreach (Account acnt in allAccountNamesWithAscend)
            {
                Console.WriteLine("Account name :" + acnt.AccountName + "\n" + "Balance :" + acnt.AccountBalance);
            }

          
           
            



        }
    }
}
