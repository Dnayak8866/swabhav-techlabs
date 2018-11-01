using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Login;
using TenantManagementApi.Models.MasterModel;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Repository
{
    public class TenantDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<LoginDetail> LoginDetails { get; set; }
       
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Announcement> Announcements { get; set; }

    }
}