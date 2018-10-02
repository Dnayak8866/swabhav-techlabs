using System;
using System.Collections.Generic;
using System.Text;

namespace AccountPolymorphismApp
{
    class SavingAccount : Account
    {
        public SavingAccount(int acno, string acntname, double balance) : base(acno, acntname, balance)
        {
        }

        public override void Withdraw(double amt)
        {
            if (this._balance - amt <= 500)
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
