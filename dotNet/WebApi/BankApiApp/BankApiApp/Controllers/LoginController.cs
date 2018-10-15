using BankApiApp.Models;
using BankApiApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BankApiApp.Controllers
{
    [RoutePrefix("api/Bank/Login")]
    public class LoginController : ApiController
    {
        private IBankRepository<Account, AccountTransaction> bankRepo = new BankRepository();

        [Route("Account/{acntno:int}/{pass:alpha}")]
        public IHttpActionResult GetAuthenticateUser(int acntno, string pass)
        {
            if (bankRepo.AuthenticateUser(acntno, pass))
            {
                return Ok("ValidAccount");
            }
            return Ok("Not_a_valid_account");

        }





    }
}