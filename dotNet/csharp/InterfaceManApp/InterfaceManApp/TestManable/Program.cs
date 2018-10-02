using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceManApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Boy boy = new Boy();
            AtThePark(man);
            AtThePark(boy);
            AtTheCinema(boy);
         //   AtTheCinema(man);
        }
        static void AtThePark(Imannable obj)
        {
            Console.WriteLine("........Imanable...........");
            obj.Wish();
            obj.Depart();

        }
        static void AtTheCinema(Iemotionable obj)
        {
            Console.WriteLine("........Iemotionable...........");
            obj.Cry();
            obj.Laugh();
        }
    }
}
