using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCrudApp
{
    interface Icrudable
    {
        void Create();
        void Read();
        void Update();
        void Remove();
    }
}
