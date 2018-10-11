using MvcApp.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models.Services
{
    public class LoginService
    {
        ContactDbContext dbContext;
        public LoginService()
        {
            dbContext = new ContactDbContext();
        }

        public bool AuthenticateUser(string username, string password)
        {
            User user = dbContext.Users.Where((u) => u.Name == username && u.Password == password)
                 .FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;
        }

    }
}