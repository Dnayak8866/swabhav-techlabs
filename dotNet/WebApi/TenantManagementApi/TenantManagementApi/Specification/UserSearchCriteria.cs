using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Specification
{
    public class UserSearchCriteria
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}