using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.DTOs
{
    public class UserDTO
    {
        public BasicDetailDTO basicdetail { get; set; }
        public LoginDetailDTO logindetail { get; set; }
        public SubscriptionDetailDTO subscriptiondetail { get; set; }
      

    }
}