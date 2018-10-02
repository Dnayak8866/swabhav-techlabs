using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp
{
    class Student
    {
        private int _rollNo;
        private int _standard;
        private string _name;

        public Student(string name,int rollno,int standard)
        {
            this._name = name;
            this._rollNo = rollno;
            this._standard = standard;
        }

        public int RollNo
        {
            get
            {
                return _rollNo;
            }
        }

        public int Standard
        {
            get
            {
                return _standard;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
       

    }
}
