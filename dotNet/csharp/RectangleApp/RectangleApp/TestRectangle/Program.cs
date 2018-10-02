using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Height = 101;
            r1.Width = -1;
            r1.BorderColor="blue";
            Console.WriteLine("Border Color :"+r1.BorderColor);
            Console.WriteLine("Area :{0}",r1.CalculateArea());

            Console.WriteLine("...... Reflection........");
            Type type = typeof(Rectangle);
            Console.WriteLine("Class name :" + type.Name + "\nNameSpace :" + type.Namespace);

            Console.WriteLine(".........Properties........");
            PropertyInfo[] propertyinfo = type.GetProperties();
            foreach (PropertyInfo property in propertyinfo )
            {
                Console.WriteLine("Property Name :"+property.Name+"\nProperty Type :"+property.PropertyType);
            }

            Console.WriteLine("..........Constructors........");
            
            foreach (ConstructorInfo constructor in type.GetConstructors())
            {
                Console.WriteLine("Constructor Name :"+constructor.ReflectedType);
            }

            Console.WriteLine("..........Methods........");

            foreach (MethodInfo method in type.GetMethods())
            {
                Console.WriteLine("Method Name :"+method.Name);
            }

          
        }
    }
}
