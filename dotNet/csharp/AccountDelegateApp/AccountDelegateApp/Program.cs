using System;
using System.Collections.Generic;
using System.Text;

namespace AccountDelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acnt1 = new Account("Dharmesh",11111);
            acnt1.OnBalancechanged += SendEmail;
            acnt1.OnBalancechanged += SendSms;
            acnt1.Deposite(500);
        }
        static void SendEmail(Account acnt)
        {
            Console.WriteLine("Email sent to Account( {0} )'s  registered email Id", acnt.AccountNo);
        }
        static void SendSms(Account acnt)
        {
            Console.WriteLine("Sms sent to Account( {0} ) registered mobile no",acnt.AccountNo);
        }
    }
}
