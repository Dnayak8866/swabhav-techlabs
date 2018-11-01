using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Models.MasterModel
{
    public class Master
    {
        [ForeignKey("UserDetails")]
        public Guid Id { get; set; }
        public virtual List<Module> Modules { get; set; }
        public virtual List<Service> Servies { get; set; }
        public virtual List<Partner> Partners { get; set; }

        public virtual User UserDetails { get; set; }

        public Master()
        {
            Id = Guid.NewGuid();
        }
    }
}