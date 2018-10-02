using System;
using System.Collections.Generic;
using System.Text;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestThreeCicleObject();
        }

        private static void TestThreeCicleObject()
        {
            double sum = 0;
            Circle[] circles = new Circle[3];
            circles[0] = new Circle(2.0f, BorderOptions.SINGLE);
            circles[1] = new Circle(1.0f, BorderOptions.DOTTED);
            circles[2] = new Circle(4.0f, BorderOptions.DOUBLE);

            for (int i = 0; i < circles.Length; i++)
            {
                sum += circles[i].CalculateArea();
            }
            Console.WriteLine("Sum of area of all the Circles are : " + sum);
        }
    }
}
