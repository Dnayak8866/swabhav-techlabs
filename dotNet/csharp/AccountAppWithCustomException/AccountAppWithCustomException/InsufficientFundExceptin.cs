using System;
using System.Collections.Generic;
using System.Text;

namespace AccountAppWithCustomException
{
    class InsufficientFundExceptin:Exception
    {
        private Account _acntHolder;
        private String _message;

        public InsufficientFundExceptin(string s, Account acntholder):this(s)
        {
            this._acntHolder = acntholder;
        }

        public InsufficientFundExceptin(String s)
        {
            this._message = s;
        }

        public override string Message
        {
            get
            {
                return "Account Holder :"+this._acntHolder.Name+" "+this._message;
            }
        }
    }
}
