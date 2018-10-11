using MvcApp.Models.Contact;
using MvcApp.Models.Login;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApp.Models.Services
{
    public class ContactDbContext:DbContext
    {
        public DbSet<contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}