using System;
using System.Collections.Generic;
using System.Text;

namespace DataServiceWithEvent
{
   
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            dataService.OnSuccess += SuccessHandler;
            dataService.OnError += ErrorHandler;
            dataService.GetData();
        }
        static void SuccessHandler(int num)
        {
            Console.WriteLine("The number {0} is greater than 5",num);
        }

        static void ErrorHandler(int num)
        {
            Console.WriteLine("The number {0} is not greater than 5", num);
        }
    }
}
