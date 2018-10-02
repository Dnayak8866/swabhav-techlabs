using System;
using System.Collections.Generic;
using System.Text;

namespace AccountAppWithCustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac2 = new Account(12, "me",500);
            try
            {
                ac2.Withdraw(100);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }

        }
    }
}
