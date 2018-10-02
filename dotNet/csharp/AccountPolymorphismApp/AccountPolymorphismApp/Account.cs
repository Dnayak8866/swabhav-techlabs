using System;
using System.Collections.Generic;
using System.Text;

namespace AccountPolymorphismApp
{
   public abstract class Account
    {
        private  int _acno;
        private  string _acntName;
        protected double _balance;
        public Account(int acno, String acntname, double balance)
        {
            this._acno = acno;
            this._acntName = acntname;
            this._balance = balance;
        }

        public string Name
        {
            get
            {
                return this._acntName;
            }
        }

        public int AcntNo
        {
            get
            {
                return _acno;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }

        public override string ToString()
        {
            return "Account Holder :" + this.Name
                + "\nAccount No :" + this.AcntNo
                + "\nBalance :" + this.Balance;
        }
        public void DepositeAmount(double amt)
        {
            this._balance += amt;
        }
        public abstract void Withdraw(double amt);

    }
}
