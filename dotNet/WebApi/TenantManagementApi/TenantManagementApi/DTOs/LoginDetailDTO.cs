﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TenantManagementApi.DTOs
{
    public class LoginDetailDTO
    {
       
        public Guid Id { get; set; }

      
        
        public string Username { get; set; }
        public string Password { get; set; }

        public string Captcha { get; set; }


      

       
    }
}