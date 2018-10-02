using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCrudApp
{
    class CustomerDb : Icrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer's create operation");
        }

        public void Read()
        {
            Console.WriteLine("Customer's Read operation");
        }

        public void Remove()
        {
            Console.WriteLine("Customer's Remove operation");
        }

        public void Update()
        {
            Console.WriteLine("Customer's Update operation");
        }
    }
}
