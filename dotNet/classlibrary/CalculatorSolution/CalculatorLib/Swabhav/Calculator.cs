using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib.Swabhav
{
   public  class Calculator
    {
        public Double CubeEvenNumber(double num)
        {
            if (num % 2 == 0)
            {
                return num * num * num;
            }
            else
            {
                throw new Exception("Number passed  in not even number..");
          
               
            }
           
        }
       
    }
}
