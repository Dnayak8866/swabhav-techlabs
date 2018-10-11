using MvcApp.Models.Contact;
using System.Collections.Generic;
using System.Linq;

namespace MvcApp.Models.Services
{
    public class ContactServices
    {

        private ContactDbContext dbContext;
        public ContactServices()
        {


            dbContext = new ContactDbContext();

        }

       

        public List<contact> ContactList
        {
            get
            {
                return dbContext.Contacts.ToList();
            }
            
        }
        
        public void AddContact(int id,string fname,string lname, string contactno, string email)
        {

            dbContext.Contacts.Add(new contact{ Id=id, Fname = fname, Lname = lname, contactNo = contactno, email = email });
            dbContext.SaveChanges();
        }

        public contact SearchContact(int id)
        {
            contact singleContact = dbContext.Contacts.Select((c) => c).Where((c) => c.Id == id).Single();
            
            return singleContact;
        }

        public void UpdateContact(contact cont)
        {
            contact  con = dbContext.Contacts.Where((c)=>c.Id==cont.Id).Single();
            con.Fname = cont.Fname;
            con.Lname = cont.Lname;
            con.contactNo = cont.contactNo;
            con.email = cont.email;
            dbContext.SaveChanges();
            
        }
    }
}