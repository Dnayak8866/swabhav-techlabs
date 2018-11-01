using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Models.Login
{
    public class LoginDetail
    {
        
        [Key, ForeignKey("UserDetails")]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        [Index(IsUnique =true)]
        public string Username { get; set; }
        public string Password { get; set; }

        public string Captcha { get; set; }

        
        public virtual User UserDetails { get; set; }

        public LoginDetail()
        {
            Id = Guid.NewGuid();
        }

       

    }
}