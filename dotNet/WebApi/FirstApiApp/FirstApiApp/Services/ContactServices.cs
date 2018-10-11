using FirstApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApiApp.Services
{
    public class ContactServices
    {
        public List<Contact> ContactList { get; set; }
        private static ContactServices _contactService;


        public ContactServices()
        {
            ContactList = new List<Contact>();
            ContactList.Add(new Contact { Name="Dharmesh",No="848435321"});
            ContactList.Add(new Contact { Name="chandan",No="84600000000"});
        }
        public static ContactServices GetInstance()
        {
            if (_contactService == null)
            {
                _contactService = new ContactServices();
            }
            return _contactService;
        }

       
        public void AddContact(Contact contact)
        {
            ContactList.Add(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return ContactList;
        }

        public Contact GetContactByName(string name)
        {
            foreach (Contact con in ContactList)
            {
                if (con.Name == name)
                {
                    return con;
                }

            }
            return null;
        }
       
    }
}