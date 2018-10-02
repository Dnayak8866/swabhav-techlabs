using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCrudApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Icrudable customer = new CustomerDb();
            DoCrudOperation(customer);
            Console.WriteLine("-----------------------------------------");
            Icrudable vender = new VenderDb();
            DoCrudOperation(vender);
            Console.WriteLine("-----------------------------------------");
            Icrudable invoice = new InvoiceDb();
            DoCrudOperation(invoice);
        }
        static void DoCrudOperation(Icrudable obj)
        {
            obj.Create();
            obj.Read();
            obj.Update();
            obj.Remove();
        }
    }
}
