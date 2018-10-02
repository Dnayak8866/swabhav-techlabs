using System;


namespace WelcomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //  Console.ReadKey();
            Console.WriteLine("Length of arg :"+args.Length);
            
            foreach( String name in args)
            {
                Console.WriteLine("Hello {0}",name);
            }
        }
    }
}
