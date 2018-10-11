using mvcBankApp.Models.TransactionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcBankApp.Models.PassbookModel
{
    public class PassbookVM
    {
        public int AccountNo { get; set; }
        public List<AccountTransaction> accountTransactionsList;

        public List<AccountTransaction> Transactions {
            get
            {
                return accountTransactionsList;
            }
        }
        public PassbookVM()
        {
            accountTransactionsList = new List<AccountTransaction>();
        }
    }
}