using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateApp
{
    delegate void Dmessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            Dmessage miniMessage;
            miniMessage = SayHello;
            miniMessage("Dharmesh");

            miniMessage = SayGoodBye;  
            miniMessage("Dharmesh");
            Console.WriteLine("---------------------------");

            Dmessage multiMessage= new Dmessage(SayHello);
            multiMessage += SayGoodBye;
           //multiMessage = SayHello;
           //multiMessage += foo;
            multiMessage("Dharmesh");
            multiMessage("Dharmesh");
            Console.WriteLine("---------------------------");
            MessageWizard(SayHello);
            MessageWizard(SayGoodBye);



        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello {0} ",name);
        }
        static void SayGoodBye(string name)
        {
            Console.WriteLine("GoodBye {0}",name);
        }
        static void foo()
        {

        }

        static void MessageWizard(Dmessage msg)
        {
            Console.WriteLine("Inside MessageWizard.......");
            msg(".....CHAMP WORK DONE.....");

        }
    }
}
