using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Models.MasterModel
{
    public class Service
    {
        public Guid Id { get; set; }
        public string ServiceName { get; set; }

        public virtual Subscription UserSubscriptionDetails { get; set; }

        public Service()
        {
            Id = Guid.NewGuid();
        }
    }
}