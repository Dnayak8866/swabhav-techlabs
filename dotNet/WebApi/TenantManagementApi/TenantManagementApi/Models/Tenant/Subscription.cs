using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.MasterModel;

namespace TenantManagementApi.Models.Tenant
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int NoNamedUser { get; set; }

        public virtual User UserDetails { get; set; }
        public virtual List<Module> UserModules { get; set; }
        public virtual List<Service> UserServices { get; set; }

        public Subscription()
        {
            Id = Guid.NewGuid();
        }
    }
}