using System;
using System.Collections.Generic;
using System.Text;

namespace AccountAppWithCustomException
{
    class Account
    {
        private int acnt_no;
        private string name;
        private double balance = 500;
        private static int count;

        static Account()
        {
            count = 1000;
            Console.WriteLine(" Static Block called once....");
        }

        public Account(int acnt_no, string name, double balance) : this(acnt_no, name)
        {
            this.balance = balance;
        }
        public Account(int acnt_no, string name) : this()
        {
            this.acnt_no = acnt_no;
            this.name = name;
        }
        public Account()
        {
            count += 1;
            Console.WriteLine("Default constructor  called");
        }

        public string Name
        {
            get
            {
                return this.name;
            }

        }

        public int AccntNo
        {
            get
            {
                return this.acnt_no;
            }

        }

        public int Count
        {
            get
            {
                return Account.count;
            }

        }
        public static int HeadCount
        {
            get
            {
                return Account.count;
            }

        }

        public void Deposite(double amt)
        {
            this.balance += amt;
            Console.WriteLine("Amount deposited successfully..");
        }
        public void Withdraw(double amt)
        {
            if ((this.balance - amt) <= 500)
            {
                throw new InsufficientFundExceptin("Minimum balance limit exceeded...",this);
            }
            else
            {
                Console.WriteLine("Withdraw done..");
                this.balance -= amt;
            }
        }
        public override string ToString()
        {
            return String.Format("Name:" + name + "\nAccount-No:" + acnt_no + "\nBalance:" + balance + "\nCount :" + this.Count + "\nHeadCount :" + HeadCount);
        }
    }
}
