using FirstApiApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstApiApp.Repository
{
    public class ContactDbContext :DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}