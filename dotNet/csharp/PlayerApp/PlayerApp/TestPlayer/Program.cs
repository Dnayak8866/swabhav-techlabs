using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerone = new Player(1, "Sachin", 50);
            Player playertwo = new Player(1, "Dhoni", 40);
            Console.Write("player one hashcode {0}\n",playerone.GetHashCode());
            Console.Write("player one hashcode {0}\n",playertwo.GetHashCode());

            Console.WriteLine("Is both player Same :"+(playerone==playertwo));

            Player elderplayer = playerone.WhoIsElder(playertwo);
            Console.WriteLine(elderplayer);
        }
    }
}
