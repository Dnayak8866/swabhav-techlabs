using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp
{
   
    class FunctionOverload
    {
        void print(int num)
        {
            Console.WriteLine("Integer  :{0}", num);
        }
        void print(float num)
        {
            Console.WriteLine("Float  :{0}", num);
        }
        void print(double num)
        {
            Console.WriteLine("Double  :{0}", num);
        }
        void print(Boolean val)
        {
            Console.WriteLine("Boolean  :{0}", val);
        }
        void print(String val)
        {
            Console.WriteLine("String  :{0}", val);
        }
        static void Main(string[] args)
        {
            FunctionOverload p = new FunctionOverload();
            p.print(10);
            p.print(1.2f);
            p.print(24.333d);
            p.print(true);
            p.print("Dharmesh");
        }
    }
}
