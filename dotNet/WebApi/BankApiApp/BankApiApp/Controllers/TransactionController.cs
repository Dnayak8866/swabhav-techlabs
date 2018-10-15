using BankApiApp.Models;
using BankApiApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BankApiApp.Controllers
{
    [RoutePrefix("api/Bank/transaction")]
    public class TransactionController : ApiController
    {
       private IBankRepository<Account, AccountTransaction> bankRepo = new BankRepository();

        
       [Route("dotransaction")]
        public IHttpActionResult PostDoTransaction(AccountTransaction acntTransaction)
        {
            acntTransaction.TransactionAmount = 10000;
            acntTransaction.TransactionDate = DateTime.Now;
            acntTransaction.TransactionType = "Deposit";
            
            bankRepo.DoTransaction(acntTransaction, 111);
                return Ok("Transaction done........");
         
        }

        [Route("AllTransactions/{accountno:int}")]
        public IHttpActionResult GetAllTransactionOfAccount(int accountno)
        {
            return Ok(bankRepo.GetSingleAccountTransaction(accountno));

        }
    }
}