using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.Tenant
{
    public class Announcement
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}