using System;
using System.Collections.Generic;
using System.Text;

namespace HumanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".......First Human.......");
            Console.WriteLine(".......Before eat........");
            Human h1 = new Human("Dharmesh", 21, 5.3f, 55.0f, GenderType.MALE);
            Console.WriteLine(h1);

            Console.WriteLine("........After eat........");
            h1.Eat();
            Console.WriteLine(h1);
            Console.WriteLine("........After Workout.........");
            h1.Workout();
            Console.WriteLine(h1);

            Console.WriteLine("...............Your HealthRecommendation................");
            h1.HealthRecommendation();
            Console.WriteLine(h1);

        }
    }
}
