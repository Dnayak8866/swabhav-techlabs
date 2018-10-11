using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models.Contact
{
    public class EditVm
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public List<contact> ContactList
        {
            get;
            set;
        }


    }
}