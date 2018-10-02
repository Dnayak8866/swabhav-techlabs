using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace StructApp
{
    struct Book
    {
        public string title;
        public string author;
        public int id;       
    }

    class BookClass
    {
        public string bookName;
    }
    
 
    class Program
    {
     
        static void Main(string[] args)
        {
            Book book1 =new Book();
            book1.title = "C programming";
            book1.author = "danis ritch";
            book1.id = 1;

            BookClass book = new BookClass();
            book.bookName = "Mybook";

            Console.WriteLine("....Before changing in main....");
            foreach (FieldInfo  field in book1.GetType().GetFields())
            {
                Console.WriteLine(field.Name+" : "+field.GetValue(book1));
            }
            Console.WriteLine("book class variable bookName :"+book.bookName);

            ChangeValue(book1,book);

            Console.WriteLine("....After changing in main ....");
            foreach (FieldInfo field in book1.GetType().GetFields())
            {
                Console.WriteLine(field.Name + " : " + field.GetValue(book1));
            }
            Console.WriteLine("Book class variable bookName :"+book.bookName);


        }
        private static void ChangeValue(Book input,BookClass book)
        {
            input.author = "Dharmesh";
            book.bookName = "Dharmesh";
            Console.WriteLine("After change in ChangeValue Method...");
            foreach (FieldInfo field in input.GetType().GetFields())
            {
                Console.WriteLine(field.Name + " : " + field.GetValue(input));
            }

            Console.WriteLine("After change in ChangeValue Method...");
            Console.WriteLine("Book class variable bookName :" + book.bookName);
        }
    }
}
