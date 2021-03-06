﻿using BankApiApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankApiApp.Repository
{
    public class BankDbContext:DbContext
    {
        public DbSet<Account> BankAccounts { get; set; }
        public DbSet<AccountTransaction> AccountTransactions { get; set; }
    }
}