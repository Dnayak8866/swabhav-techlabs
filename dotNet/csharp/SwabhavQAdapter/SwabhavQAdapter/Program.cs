using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwabhavQAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericAdapter<string> adapter = new GenericAdapter<string>();
            adapter.eQueue("dharmesh");
            adapter.eQueue("chandan");
            adapter.eQueue("abhishek");
            foreach (string s in adapter)
            {
                Console.WriteLine(s);
            }
        }
    }
}
