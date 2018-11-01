using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.DTOs
{
    public class SubscriptionDetailDTO
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int NoOfNamedUser { get; set; }

     
        public List<string> Modules { get; set; }
        public  List<string> Services { get; set; }
    }
}