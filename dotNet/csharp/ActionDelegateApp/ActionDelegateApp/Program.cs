using System;
using System.Collections.Generic;
using System.Text;

namespace ActionDelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> PrintName = ShowName;
            PrintName("Dharmesh Nayak");
        }
        static void ShowName(string name)
        {
            Console.WriteLine(name);
        }
    }
}
