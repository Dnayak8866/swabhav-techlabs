using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.Tenant
{
    public class ContactDetail
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual User UserDetails { get; set; }
        
        public ContactDetail()
        {
            Id = Guid.NewGuid();
        }
    }
}