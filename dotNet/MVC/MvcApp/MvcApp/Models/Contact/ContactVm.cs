using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models.Contact
{
    public class ContactVm
    {
        List<contact> contactList = new List<contact>();

        public List<contact> ContactList
        {
            get
            {
                return contactList;
            }
            set
            {
                contactList = value;
            }
        }
    }
}