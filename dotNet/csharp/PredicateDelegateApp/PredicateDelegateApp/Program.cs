using System;
using System.Collections.Generic;
using System.Text;

namespace PredicateDelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = CheckEven;
            Console.WriteLine(isEven(4));
            Console.WriteLine(isEven(5));
        }
        static bool CheckEven(int num)
        {
            if (num%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
