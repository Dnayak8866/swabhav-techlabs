using System;
using System.Collections.Generic;
using System.Text;

namespace DataServiceApp
{
   
    class DataService
    {
          public void GetData(DSuccess success, DError error)
          {
              Random random = new Random();
              int num = random.Next(1, 10);
              Console.WriteLine(num);

              if (num > 5)
              {
                  success("Number greater than 5");
              }
              else
              {
                  error("Number is less than 5");
              }

          }

       
    }
}
