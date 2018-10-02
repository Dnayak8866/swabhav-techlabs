using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceManApp
{
    class Boy : Imannable, Iemotionable
    {
        public void Cry()
        {
            Console.WriteLine("Boy cry...........");
        }

        public void Depart()
        {
            Console.WriteLine("Boy departs...........");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy Laugh...........");
        }

        public void Wish()
        {
            Console.WriteLine("Boy Wishes...........");
        }
    }
}
