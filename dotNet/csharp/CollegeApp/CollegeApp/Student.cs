using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeApp
{
    class Student : Person
    {
        public Student(string name, string address, string dob, int id, Branch branch) : base(name, address, dob, id, branch)
        {

        }
    }
}
