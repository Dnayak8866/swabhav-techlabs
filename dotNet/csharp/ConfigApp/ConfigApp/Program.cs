using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;

namespace ConfigApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1, value2;
           
            value1 = ConfigurationManager.AppSettings.Get("data1");
            value2 = ConfigurationManager.AppSettings.Get("data2");
            Console.WriteLine("Appsetting value1 of key data1 :"+value1);
            Console.WriteLine("Appsetting value1 of key data2 :" + value2);

            NameValueCollection allKeys;
            allKeys = ConfigurationManager.AppSettings;

            foreach (string key in allKeys)
            {
                Console.WriteLine("Value of {0} is {1}",key,allKeys.Get(key)) ;
            }

        }
    }
}
