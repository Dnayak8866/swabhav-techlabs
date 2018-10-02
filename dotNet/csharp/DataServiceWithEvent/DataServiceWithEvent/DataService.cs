using System;
using System.Collections.Generic;
using System.Text;

namespace DataServiceWithEvent
{
    public delegate void DResult(int num); 
    class DataService
    {
        public event DResult OnSuccess;
        public event DResult OnError;
        public void GetData()
        {
            Random random = new Random();
            int num = random.Next(1, 10);
            Console.WriteLine(num);

            if (num > 5)
            {
                OnSuccess(num);
            }
            else
            {
                OnError(num);
            }
        }
    }
}
