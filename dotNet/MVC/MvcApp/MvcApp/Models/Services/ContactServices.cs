using MvcApp.Models.Contact;
using System.Collections.Generic;

namespace MvcApp.Models.Services
{
    public class ContactServices
    {
        List<contact> contactList;
        public ContactServices()
        {
            contactList = new List<contact>();
            contactList.Add(new contact() {contactNo="989898898",Fname="Chandan",Lname="Maharana",email="ascaas@gmail.com"});
            contactList.Add(new contact() { contactNo = "8866666666", Fname = "Dharmesh", Lname = "Nayak",email="dmax@yahoo.co.in" });
            contactList.Add(new contact() { contactNo = "903333333", Fname = "Abhi", Lname = "Singh",email="foooo@gmail.com" });
            contactList.Add(new contact() { contactNo = "96525558888", Fname = "Dhiraj", Lname = "Giti" ,email="fooo@gmail.com"});
           

        }

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

        public void AddContact(string fname,string lname, string contactno, string email)
        {

            contactList.Add(new contact{ contactNo = contactno, Fname = fname, Lname = lname, email = email });

        }
    }
}