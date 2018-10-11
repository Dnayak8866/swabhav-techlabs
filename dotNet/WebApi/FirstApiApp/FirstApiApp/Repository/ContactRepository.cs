using FirstApiApp.Models;
using FirstApiApp.Repository.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApiApp.Repository
{
    public class ContactRepository : IRepository<Contact>
    {
        private ContactDbContext _dbContext;
        public List<Contact> ContactList { get; set; }
     //   private static ContactRepository _contactRepo;

        public ContactRepository()
        {
            _dbContext = new ContactDbContext();
      /*      ContactList = new List<Contact>();
            ContactList.Add(new Contact { Name = "Dharmesh", No = "848435321" });
            ContactList.Add(new Contact { Name = "chandan", No = "84600000000" }); */
        }

     /*   public static ContactRepository GetInstance()
        {
            if (_contactRepo == null)
            {
                _contactRepo = new ContactRepository();
            }
            return _contactRepo;
        } */

        public Guid Add(Contact entity)
        {
          //  _dbContext.Contacts.Add(entity);
           // _dbContext.SaveChanges();
            // ContactList.Add(entity);
            using (var unitOfWork = new UnitOfWorkScope<ContactDbContext>(UnitOfWorkScopePurpose.Writing))
            {
                unitOfWork.DbContext.Contacts.Add(entity);
                //  unitOfWork.DbContext.SaveChanges();
                unitOfWork.SaveChanges();
               
            }
            return entity.Id;

        }

        public void Delete(Guid entityId)
        {
            ContactList.Remove(GetById(entityId));
        }

        public Contact GetById(Guid entityId)
        {
            foreach (Contact cont in ContactList)
            {
                if (cont.Id == entityId)
                {
                    return cont;
                }

            }
            return null;
        }

        public void Update(Contact entity)
        {
            for (int i = 0; i < ContactList.Count; i++)
            {
                if (ContactList[i].Id == entity.Id)
                {
                    ContactList[i] = entity;
                }
            }
        }

        public List<Contact> GetAll()
        {
            using (var unitofwork = new UnitOfWorkScope<ContactDbContext>(UnitOfWorkScopePurpose.Reading))
            {
                return unitofwork.DbContext.Contacts.ToList();
            }
               
        }


        public List<Contact> Search(ISpecification<Contact> specification)
        {
            using (var unitofwork = new UnitOfWorkScope<ContactDbContext>(UnitOfWorkScopePurpose.Reading))
            {
                return unitofwork.DbContext.Contacts.Where(specification.Search).ToList();
            }
              
        }

        

    }
}