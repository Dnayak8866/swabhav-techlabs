using System;
using System.Collections.Generic;
using System.Text;

namespace AccountPolymorphismApp
{
    class CurrentAccount : Account
    {
        public CurrentAccount(int acno, String acntname, double balance):base(acno,acntname,balance)
        {
            
        }
        public override void Withdraw(double amt)
        {
            if ((this._balance - amt) < (-5000))
            {
                Console.WriteLine("Cannot withdraw....Limit Exceed");
            }
            else
            {
                this._balance = this._balance - amt;
            }
        }
    }
}
