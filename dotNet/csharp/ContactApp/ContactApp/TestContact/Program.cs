using System;
using System.Collections.Generic;
using System.Text;

namespace ContactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactServiceProvider serviceProvider = new ContactServiceProvider();
            List<Contact> nameList = new List<Contact>();
            Console.WriteLine(".....Add Contact.....");
            string name, mob;
            bool isToCheck = true;

            while (isToCheck)
            {
                Console.WriteLine("1:Add Contact");
                Console.WriteLine("2.Quit");
                Console.WriteLine("3.Display Contact");
                Console.WriteLine("Enter your choice :");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Enter your  name :");
                        name = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Enter your Contact number:");
                        mob = Convert.ToString(Console.ReadLine());

                        serviceProvider.AddContact(name,mob);

                        break;

                    case 2:
                        isToCheck = false;
                        Console.WriteLine("...Oops your are out of Contact app...");
                        break;

                    case 3:
                       nameList= serviceProvider.NameList;
                        foreach (Contact contact in nameList)
                        {
                            Console.WriteLine(contact);
                        }
                        break;
                    
        

                }
                    

            }
        }
    }
}
