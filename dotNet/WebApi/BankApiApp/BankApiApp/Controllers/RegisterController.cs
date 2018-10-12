using BankApiApp.Models;
using BankApiApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace BankApiApp.Controllers
{
    [RoutePrefix("api/Bank/Registration")]
    public class RegisterController:ApiController
    {
        private IBankRepository<Account, AccountTransaction> bankRepo = new BankRepository();

        [Route("RegisterAccount")]
        public IHttpActionResult PostRegisterAccount(Account acnt)
        {
            bankRepo.RegisterAccount(acnt);
            return Ok("Account Registered....");
        }   
            

    }
}