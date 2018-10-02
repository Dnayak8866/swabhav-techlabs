using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transactionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Merchant merchant1 = new Merchant(1);
            Customer customer1 = new Customer(111);
            Console.WriteLine("Enter purchase amount :");
            int purchaseamount = Convert.ToInt32(Console.ReadLine());
            customer1.Purchase(merchant1, purchaseamount);
        }
    }
}
