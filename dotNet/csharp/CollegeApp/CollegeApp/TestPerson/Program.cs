using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Dharmesh", "my address",  "22/12/1995", 1111,
                Branch.COMPUTER);
            displayPerson(s1);
     
            Professor p1 = new Professor("profesor-a", "professor-add", "11/11/1989", 222, Branch.COMPUTER, 9);
            p1.CalculateSalary();
            displayPerson(p1);
        }

        private static void displayPerson(Person obj)
        {
            Professor p = null;
            String name=obj.GetType().Name.ToString();
            Console.WriteLine(name + "............ :");
            if (name.Equals("student", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine(" Name : " + obj.Name + "\n Id : "
                    + obj.Id + "\n Address : " + obj.Address
                    + "\n DOB : " + obj.Dob + "\n Branch :"
                    + obj.Branch+"\n.....................................................");
            }else
            {
                p = (Professor)obj;
                Console.WriteLine(" Name : " + p.Name + "\n Id : "
                    + p.Id + "\n Address : " + p.Address
                    + "\n DOB : " + obj.Dob + "\n Branch :"
                    + p.Branch+"\n Salary :"+
                    p.TotalSalary+"\n.....................................................");

            }
            
        }
    }
}
