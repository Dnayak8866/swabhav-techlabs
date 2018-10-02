using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "dharmesh","chandan","sunil","Abhishek"};
            IEnumerable<string> friendsnames = names;

            IEnumerable<string> namesWithA = names.Where((n)=>n.Contains("A"));
            IEnumerable<string> namesWithAandLengthAboove4 = namesWithA.Where((n)=>n.Length>4);

            foreach (string name in namesWithAandLengthAboove4)
            {
                Console.WriteLine(name);
            }
        }
    }
}
