using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Login;

using TenantManagementApi.Models.MasterModel;

namespace TenantManagementApi.Models.Tenant
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Currency { get; set; }
        public string ShortName { get; set; }
        public string UserRole { get; set; }
        public string WebUrl { get; set; }

        public virtual List<Address> UserAddress { get; set; }
        public virtual List<ContactDetail> Contact { get; set; }


        public virtual LoginDetail LoginDetails { get; set; }
        public virtual List<Subscription> UserSubscriptionsDetails { get; set; }

       

       
        public virtual Master UserMasterDetails { get; set; }



        public User()
        {
            Id = Guid.NewGuid();
        }
        
    }
}