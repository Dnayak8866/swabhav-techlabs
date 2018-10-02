using System;
using System.Text.RegularExpressions;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.xyzvzvz.com?user=\"dharmesh\"";
           
          
            string[] splittedString = Regex.Split(url, "[:|?|\"]");
            foreach (string splittedstr in splittedString)
            {
                Console.WriteLine(splittedstr);
            }

            for (int i = 1; i < splittedString.Length; i++)
            {
                switch (i)
                {
                    case 1:
                        int l = splittedString[i].Length;
                        Console.WriteLine(l);
                        string domain = splittedString[i].Substring(2, l-2);
                        Console.WriteLine("Doman is:{0} ", domain);
                        break;
                    case 3:
                        Console.WriteLine("User is: {0}", splittedString[i]);
                        break;
                   
                }
               
            }


        }
    }
}
