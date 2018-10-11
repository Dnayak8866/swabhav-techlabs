using FirstApiApp.Models;
using FirstApiApp.Repository;
using FirstApiApp.Services;
using FirstApiApp.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace FirstApiApp.Controllers
{
    [RoutePrefix("api/hitech/Contacts")]
    public class ContactController: ApiController
    {
        //   private ContactServices contactService = ContactServices.GetInstance();

        //  private IRepository<Contact> _contactRepo = ContactRepository.GetInstance();
        private IRepository<Contact> _contactRepo = new ContactRepository();
        [Route("Allcontacts")]
        public IHttpActionResult GetAllContacts()
        {
            return Ok(_contactRepo.GetAll());
        }

        [Route("Addcontact")]
        public IHttpActionResult PostAddContact(Contact contact)
        {
            _contactRepo.Add(contact);

            return Ok("Contact Added..");
        }

        [Route("Contactname/{name:alpha}")]
        public IHttpActionResult GetContactByName(string name)
        {
            var searchcriteria = new ContactSearchCriteria();
            searchcriteria.ContactName = name;

            var searchSpecification = new ContactSpecificationForSearch(searchcriteria);
            return Ok(_contactRepo.Search(searchSpecification)); 
        }

        [Route("ContactId/{id}")]
        public IHttpActionResult GetContactById(string id)
        {
            var searchcriteria = new ContactSearchCriteria();
            searchcriteria.ContactId = Guid.Parse(id);
            

            var searchSpecification = new ContactSpecificationForSearch(searchcriteria);
            return Ok(_contactRepo.Search(searchSpecification));
        }

        [Route("Contact/{name:alpha}/{id}")]
        public IHttpActionResult GetContactByNameId(string name,string id)
        {
            var searchcriteria = new ContactSearchCriteria();
            searchcriteria.ContactId = Guid.Parse(id);
            searchcriteria.ContactName = name;


            var searchSpecification = new ContactSpecificationForSearch(searchcriteria);
            return Ok(_contactRepo.Search(searchSpecification));
        }





    }
}