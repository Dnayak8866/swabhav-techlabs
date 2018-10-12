using BankApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApiApp.Repository
{
    interface IBankRepository<T,V>
    {
        void RegisterAccount(T entity);
        List<T> GetAllAccounts();
        void DoTransaction(V acntTransaction,int acntno);
        List<V> GetAllTransactions();
        bool AuthenticateUser(int acntno,string pass);
        T GetLoggedInAccount(int acntno);
        List<V> GetSingleAccountTransaction(int acntno);
        void DownloadeStatement(List<V> transactionList);

    }
}
