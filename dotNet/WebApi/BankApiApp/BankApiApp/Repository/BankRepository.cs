using BankApiApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;

namespace BankApiApp.Repository
{
    public class BankRepository:IBankRepository<Account,AccountTransaction>
    {
        private BankDbContext _dbContext;
        public Account _currentAcntHolder { get; set; }

        public BankRepository()
        {
            _dbContext = new BankDbContext();
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
                    acntTransaction.acnt = acnt;
                    _dbContext.AccountTransactions.Add(acntTransaction);
                    _dbContext.SaveChanges();
                    transaction.Commit();

                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
            }

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

        public List<Account> GetAllAccounts()
        {
            return _dbContext.BankAccounts.ToList();
        }

        public List<AccountTransaction> GetAllTransactions()
        {
            return _dbContext.AccountTransactions.ToList();
        }

        public Account GetLoggedInAccount(int acntno)
        {
            return _dbContext.BankAccounts.Where((e) => e.AccountNo == acntno).Select((a) => a).SingleOrDefault();
        }

        public List<AccountTransaction> GetSingleAccountTransaction(int acntno)
        {
            return _dbContext.AccountTransactions.Where((a) => a.acnt.AccountNo == acntno).ToList();    
        }

        public void RegisterAccount(Account entity)
        {
             entity.AccountCreatedDate = DateTime.Now;
            _dbContext.BankAccounts.Add(entity);
            _dbContext.SaveChanges();
        }
    }
}