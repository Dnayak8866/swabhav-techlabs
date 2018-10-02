using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCrudApp
{
    class InvoiceDb : Icrudable
    {
        public void Create()
        {
            Console.WriteLine("Invoice's Create operations........");
        }

        public void Read()
        {
            Console.WriteLine("Invoice's Read operations........");
        }

        public void Remove()
        {
            Console.WriteLine("Invoice's Remove operations........");
        }

        public void Update()
        {
            Console.WriteLine("Invoice's Update operations........");
        }
    }
}
