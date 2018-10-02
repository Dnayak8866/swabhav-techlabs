using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeApp
{
    class Professor :Person,SalariedEmployee
    {
        private static double _salaryPerHour;
        private int _totalWorkingHours;
        private double _totalSalary;

        static Professor()
        {
            _salaryPerHour = 500;
        }

        public Professor(string name,string address,string dob,int id,Branch branch,int workinghours):base(name,address,dob,id,branch)
        {
            this._totalWorkingHours = workinghours;
        }

        public double TotalSalary
        {
            get
            {
                return _totalSalary;
            }
        }

        public double CalculateSalary()
        {
            this._totalSalary = this._totalWorkingHours * Professor._salaryPerHour;
            return _totalSalary;
        }
    }
}
