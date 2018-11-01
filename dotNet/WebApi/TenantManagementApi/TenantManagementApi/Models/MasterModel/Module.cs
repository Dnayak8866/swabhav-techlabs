using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Models.MasterModel
{
    public class Module
    {
        public Guid Id { get; set; }
        public string ModuleName { get; set; }

        public virtual Subscription UserSubscriptionDetails { get; set; }
        
        public Module()
        {
            Id = Guid.NewGuid();
        }
    }
}