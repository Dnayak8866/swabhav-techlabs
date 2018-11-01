using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.Tenant
{
    public class Partner
    {
        public Guid Id { get; set; }
        public string PartnerName { get; set; }
        public Partner()
        {
            Id = Guid.NewGuid();
        }
    }
}