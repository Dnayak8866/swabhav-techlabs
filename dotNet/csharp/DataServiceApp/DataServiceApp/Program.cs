using System;
using System.Collections.Generic;
using System.Text;

namespace DataServiceApp
{
    delegate void DError(string errorMsg);
    delegate void DSuccess(string successMsg);
   
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            dataService.GetData(SuccessFunction,ErrorFunction); 
        }

        static void ErrorFunction(string msg)
        {
            Console.WriteLine("Inside error function");
            Console.WriteLine(msg);
        }

        static void SuccessFunction(string msg)
        {
            Console.WriteLine("Inside Success function");
            Console.WriteLine(msg);
        }
    }
}
