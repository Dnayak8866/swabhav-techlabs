using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models.Dept
{
    public class DeptVm
    {
        private List<Department> _deptList;
        private string _selectedDeptno;
        private List<Employee> _selectedEmpList;
    

        public DeptVm()
        {
            
        }
        public List<Department> DeptList
        {
            get
            {
                return _deptList;
            }
            set
            {
                _deptList = value;
            }
        }


        public string SelectedDeptNo
        {
            get
            {
                return _selectedDeptno;
            }
            set
            {
                _selectedDeptno = value;
            }
        }

        public List<Employee> SelectEmpList
        {
            get
            {
                return _selectedEmpList;
            }
            set
            {
                _selectedEmpList =value;
            }
        }


          
    }
}