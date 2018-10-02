using System;
using System.Collections.Generic;
using System.Text;

namespace AccountDelegateApp
{
   public delegate void DBalanceChanged(Account acnt);
   public  class Account
    {
        private int _acntNo;
        private double _balance;
        private string _name;

        public event DBalanceChanged OnBalancechanged;

        public Account(string name,int acntNo)
        {
            this._name = name;
            this._acntNo = acntNo;
        }

        public int AccountNo
        {
            get
            {
                return _acntNo;
            }
        }
        public void Deposite(double amt)
        {
            this._balance += amt;
            if (OnBalancechanged!=null)
            {
                OnBalancechanged(this);
            }

        }

        public void Withdraw(double amt)
        {
            this._balance -= amt;
            if (OnBalancechanged != null)
            {
                OnBalancechanged(this);
            }
        }


    }
}
