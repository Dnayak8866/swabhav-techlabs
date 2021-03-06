﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.DTOs
{
    public class AddressDetailDTO
    {

        public Guid Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
    }
}