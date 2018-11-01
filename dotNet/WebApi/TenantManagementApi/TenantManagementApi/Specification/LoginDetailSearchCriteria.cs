using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Specification
{
    public class LoginDetailSearchCriteria
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
    }
}