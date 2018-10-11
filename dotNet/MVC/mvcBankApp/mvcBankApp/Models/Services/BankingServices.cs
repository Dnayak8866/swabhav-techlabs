using mvcBankApp.Models.RegistrationModel;
using mvcBankApp.Models.TransactionModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;

namespace mvcBankApp.Models.Services
{
    public class BankingServices
    {
        private BankDbContext _dbContext;
        public Account _currentAcntHolder { get; set; }

        public BankingServices(BankDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void RegisterAccount(Account acnt)
        {
            _dbContext.BankAccounts.Add(acnt);
            _dbContext.SaveChanges();
        }

        public List<Account> GetAllAccounts()
        {
            return _dbContext.BankAccounts.ToList();
        }

        public void DoTransaction(AccountTransaction acntTransaction, int acntno)
        {
            using (DbContextTransaction transaction = _dbContext.Database.BeginTransaction())
            {
                Account acnt = _dbContext.BankAccounts.Where((a) => a.AccountNo == acntno).Select((a) => a).SingleOrDefault();
                try
                {
                    if (acntTransaction.TransactionType == "Deposit")
                    {
                        acnt.AccountBalance += acntTransaction.TransactionAmount;

                    }
                    else if (acntTransaction.TransactionType == "Withdraw")
                    {
                        acnt.AccountBalance -= acntTransaction.TransactionAmount;
                    }
                    _dbContext.AccountTransactions.Add(acntTransaction);
                    _dbContext.SaveChanges();
                    transaction.Commit();

                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }



        }

        public List<AccountTransaction> GetAllTransactions()
        {
            return _dbContext.AccountTransactions.ToList();
        }

        public bool AuthenticateUser(int acntno, string pass)
        {
            Account acnt = _dbContext.BankAccounts.Where((a) => a.AccountNo == acntno && a.AccountPassword == pass).Select((a) => a).SingleOrDefault();
            if (acnt == null)
            {
                return false;
            }
            _currentAcntHolder = acnt;
            return true;
        }

        public Account GetLoggedInAccount(int acntno)
        {
            return _dbContext.BankAccounts.Where((e) => e.AccountNo == acntno).Select((a) => a).SingleOrDefault();

        }

        public List<AccountTransaction> GetSingleAccountTransaction(int acntno)
        {
            return _dbContext.AccountTransactions.Where((a) => a.acnt.AccountNo == acntno).ToList();
        }

        public void DownloadeStatement(List<AccountTransaction> transactionList)
        {
            var Response = System.Web.HttpContext.Current.Response;
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=transaction_details.csv");
            Response.Charset = "";
            Response.ContentType = "application/text";


            StringBuilder columnbind = new StringBuilder();

            columnbind.Append("AcntNo" + ',' + "TransactionType" + ',' + "Amount" + ',' + "Date" + ',');
            columnbind.Append("\r\n");
            foreach (var data in transactionList)
            {

                columnbind.Append(data.acnt.AccountNo + ",");
                columnbind.Append(data.TransactionType + ",");
                columnbind.Append(data.TransactionAmount + ",");
                columnbind.Append(data.TransactionDate + ",");

                columnbind.Append("\r\n");
            }

            Response.Output.Write(columnbind.ToString());
            Response.Flush();
            Response.End();
        }
    }
}