using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLinqQueryApp
{
    class Employee
    {
        private int _empNo;
        private string _empName;
        private string _empJob;
        private string _empMgr;
        private string _hireDate;
        private int _empSalary;
        private int _empComisn;
        private int _empDeptNo;

        public Employee(int no, string name, string job, string mgr, string hiredate, int salary, int commisn, int deptno)
        {
            _empNo = no;
            _empName = name;
            _empJob = job;
            _empMgr = mgr;
            _hireDate = hiredate;
            _empSalary = salary;
            _empComisn = commisn;
            _empDeptNo = deptno;

        }
        public int EmpNo
        {
            get
            {
                return _empNo;
            }


        }

        public string EmpName
        {
            get
            {
                return _empName;
            }


        }

        public string EmpJob
        {
            get
            {
                return _empJob;
            }


        }

        public string Mgr
        {
            get
            {
                return _empMgr;
            }


        }

        public string HireDate
        {
            get
            {
                return _hireDate;
            }


        }

        public int EmpSalary
        {
            get
            {
                return _empSalary;
            }


        }

        public int EmpComisn
        {
            get
            {
                return _empComisn;
            }


        }

        public int EmpDeptNo
        {
            get
            {
                return _empDeptNo;
            }

        }

        public override string ToString()
        {
            return "Emo no :" + _empNo
                + "| EmpName:" + _empName
                + "| Job :" + _empJob
                + "\nMgr :" + _empMgr
                + "| Hire Date:" + _hireDate
                + "| Salary:" + _empSalary
                + "\nCommisiion:" + _empComisn
                + "| Emp Dept No:" + _empDeptNo
                +"\n-----------------------------------------------------";
        }
    }
}
