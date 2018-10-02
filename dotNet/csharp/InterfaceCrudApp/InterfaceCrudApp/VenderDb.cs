using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCrudApp
{
    class VenderDb : Icrudable
    {
        public void Create()
        {
            Console.WriteLine("Vender's Create operation.......");
        }

        public void Read()
        {
            Console.WriteLine("Vender's Read operation.......");
        }

        public void Remove()
        {
            Console.WriteLine("Vender's Remove operation.......");
        }

        public void Update()
        {
            Console.WriteLine("Vender's Update operation.......");
        }
    }
}
