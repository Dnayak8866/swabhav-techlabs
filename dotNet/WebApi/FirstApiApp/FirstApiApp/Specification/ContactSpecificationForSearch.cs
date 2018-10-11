using FirstApiApp.Models;
using FirstApiApp.Repository;
using System;
using System.Linq.Expressions;

namespace FirstApiApp.Specification
{
    public class ContactSpecificationForSearch : ISpecification<Contact>
    {
        private ContactSearchCriteria _criteria;

        public ContactSpecificationForSearch(ContactSearchCriteria criteria)
        {
            _criteria = criteria;
        }


   /*     public Func<Contact, bool> Search
        {
            get
            {
                Func<Contact, bool> query=null;

                if (_criteria.ContactName!=string.Empty)
                {
                    query = (x) => x.Name == _criteria.ContactName ;
                    
                }
                if (_criteria.ContactId!=Guid.Empty)
                {
                    query = (x) => x.Id == _criteria.ContactId;
                }
                if (_criteria.ContactId!=Guid.Empty && _criteria.ContactName!=string.Empty)
                {
                    query = (x) => x.Name == _criteria.ContactName && x.Id == _criteria.ContactId;
                }
                return query;
            }
        } */

        Expression<Func<Contact, bool>> ISpecification<Contact>.Search
        {
            get
            {
               Expression<Func<Contact, bool>> query = null;

                if (_criteria.ContactName != string.Empty)
                {
                    query = (x) => x.Name == _criteria.ContactName;

                }
                if (_criteria.ContactId != Guid.Empty)
                {
                    query = (x) => x.Id == _criteria.ContactId;
                }
                if (_criteria.ContactId != Guid.Empty && _criteria.ContactName != string.Empty)
                {
                    query = (x) => x.Name == _criteria.ContactName && x.Id == _criteria.ContactId;
                }
                return query;
            }
        }
    }
}