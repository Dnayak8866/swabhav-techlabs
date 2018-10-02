using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CustomerApp
{
    class Customer
    {
        private string _firstname;
        private string _lastname;
        private DateTime _dob;
        private static int _id;
        private int _customerId;

        static Customer()
        {
            _id = 100;
        }

        public Customer(string firstname,string lastname,string dob)
        {
            _id += 1;
            this._customerId = Customer._id;
            this._firstname = firstname;
            this._lastname = lastname;
            this._dob = ConvertToDate(dob);
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
        }

        public string Lastname
        {
            get
            {
                return _lastname;
            }
        }

        public int CustomerId
        {
            get
            {
                return _customerId;
            }
        }
        private DateTime ConvertToDate(string dob)
        {

            DateTime birthdate = Convert.ToDateTime(dob);
            
         
            return birthdate;        
        }

        public string Birthdate
        {
            get
            {
                return _dob.ToLongDateString();
            }
        }

        public int CalculateAge()
        {
            int currentyear, birthyear, age;  
            currentyear= DateTime.Now.Year;
            birthyear = this._dob.Year;
            age = currentyear - birthyear;
            return age;
        }
    }
}
