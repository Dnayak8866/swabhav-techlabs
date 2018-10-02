using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Dharmesh", "Nayak", "22/12/1995");
            Customer c2 = new Customer("Chandan", "Maharana", "22/11/1996");

            printDetails(c1);
            Console.WriteLine("--------------------------------------------");
            printDetails(c2);

        }

        private static void printDetails(Customer c)
        {
            Console.WriteLine("Firstname :" + c.Firstname
                + "\nLastname :" + c.Lastname
                + "\nBirthdate :" + c.Birthdate
                + "\nCustomer Id :" + c.CustomerId
                + "\nAge :" + c.CalculateAge());
        }
    }
}
