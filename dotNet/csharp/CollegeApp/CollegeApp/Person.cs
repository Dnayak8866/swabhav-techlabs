using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeApp
{
    class Person
    {
        private string _name;
        private int _id;
        private string _address;
        private string _dob;
        private Branch branch;

        public Person(string name,string address,string dob,int id,Branch branch)
        {
            this._name = name;
            this._address = address;
            this._dob = dob;
            this._id = id;
            this.branch = branch;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
        }

        public string Dob
        {
            get
            {
                return _dob;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Branch
        {
            get
            {
                return this.branch.ToString();
            }
        }
    }
}
