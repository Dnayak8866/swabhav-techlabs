using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transactionApp;

namespace transactionApp
{
    class Customer
    {
        private int _id;
        private string _name;
        private int _balance;

        public Customer(int id)
        {
            this._id = id;
        }

        public int Id
        {
            get
            {
                return _id;
            }

           
        }

        public string Name
        {
            get
            {
                return _name;
            }

            
        }

        public int Balance
        {
            get
            {
                return _balance;
            }

           
        }

        public void Purchase(Merchant merchant,int purchaseamount)
        {
            TransactionService transactionservice = new TransactionService();
            transactionservice.MakeTransaction(merchant,purchaseamount,this.Id);
        }
    }
}
