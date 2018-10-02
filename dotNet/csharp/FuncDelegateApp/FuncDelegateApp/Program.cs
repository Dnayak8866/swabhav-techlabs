using System;
using System.Collections.Generic;
using System.Text;

namespace FuncDelegateApp
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Func<int, int, int> Add = Sum;
            int result = Add(2, 4);
            Console.WriteLine(result);
        }

        static int Sum(int a,int b)
        {
            return a + b;
        }
    }
}
