using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceManApp
{
    class Man : Imannable
    {
        public void Depart()
        {
            Console.WriteLine("Man Departs.......");
        }

        public void Wish()
        {
            Console.WriteLine("Man Wishes.........");
        }
    }
}
