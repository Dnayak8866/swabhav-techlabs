using System;
using System.Collections.Generic;
using System.Text;

namespace ContactApp
{
    class ContactServiceProvider
    {
        StoreData s1 = new StoreData();
        public List<Contact> contactList;

        public ContactServiceProvider()
        {
            this.contactList = s1.GetData();
        }

        public void AddContact(string name,string number)
        {
            this.contactList.Add(new Contact(name,number));
            s1.SerializeTheList(this.contactList);
        }

        public List<Contact> NameList
        {
            get
            {
                return this.contactList;
            }
        }
    }
}
