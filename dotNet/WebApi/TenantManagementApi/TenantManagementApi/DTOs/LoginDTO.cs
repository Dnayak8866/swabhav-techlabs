﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.DTOs
{
    public class LoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}