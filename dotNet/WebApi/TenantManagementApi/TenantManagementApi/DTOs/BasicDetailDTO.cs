using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.DTOs
{
    public class BasicDetailDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Currency { get; set; }
        public string ShortName { get; set; }
        public string UserRole { get; set; }
        public string WebUrl { get; set; }

        public List<AddressDetailDTO> address { get; set; }
        public List<ContactDetailDTO> contact { get; set; }
    }
}