using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new Account(111,"Dharmesh",500);
            ac1.Withdraw(100);
            
            Console.WriteLine(ac1);

            Console.WriteLine("----------------------------------------------------");

            Account ac2 = new Account(222, "Chandan", 1000);
            ac2.Deposite(500);
            Console.WriteLine(ac2);
         
        }
    }
}
