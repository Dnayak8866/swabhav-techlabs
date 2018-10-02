using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore
{
  public class ContactServiceProvider
    {
        FileStore s1 = new FileStore();
        public List<Contact> contactList;
        public DatabaseStore dbStore = new DatabaseStore();

        public ContactServiceProvider()
        {
            
            try
            {
               
                //  this.contactList = s1.GetData();
                this.contactList = dbStore.getAllContactsFromDatabase();
            }
            catch (SerializationException e)
            {
                Console.WriteLine("No data in file...");
                contactList = new List<Contact>();
                

            }
                
           
        }

        public void AddContact(string name, string number)
        {
            this.contactList.Add(new Contact(name, number));
            //   s1.SerializeTheList(this.contactList);
            dbStore.storeContactToDatabase(new Contact(name,number));
        }

        public List<Contact> SearchContact(string name)
        {
            List<Contact> contactsMatchList  = new List<Contact>();
            foreach (Contact contact in contactList)
            {
                if (contact.Name.ToUpper().Contains(name.ToUpper()))
                {
                    contactsMatchList.Add(contact);
                }
            }
            return contactsMatchList;
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
