using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.Tenant
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }

        public virtual User UserDetails { get; set; }

        public Address()
        {
            Id = Guid.NewGuid();
        }
    }
}