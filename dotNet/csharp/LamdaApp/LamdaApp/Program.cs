using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaApp
{
    class Program
    {
       // public delegate void Dmessage(string s) ;
        static void Main(string[] args)
        {
            //  Dmessage msg;
            Action<string> msg;
            msg = SayHello;
            msg("Dharmesh");

            msg = SayGoodBye;
            msg("Dharmesh");

            MessageWizard(SayHello);
            MessageWizard(SayGoodBye);
            MessageWizard((n)=> { Console.WriteLine("Name :" + n); });

            Func < int,int> sqr = (x) => x * x;
            Console.WriteLine("Using func "+sqr(2));

            Predicate<int> iseven = (n) =>
            {
                if (n % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            Console.WriteLine("IS even number "+iseven(4));
            Console.WriteLine("IS even number " + iseven(5));
        }

        static void SayHello(string s)
        {
            Console.WriteLine("Hello "+s);
        }
        static void SayGoodBye(string s)
        {
            Console.WriteLine("Good bye "+s);
        }

        static void MessageWizard(Action<string> message)
        {
            message("Dharmesh.......");
        }
    }
}
