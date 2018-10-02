using System;
using System.Collections.Generic;
using System.Text;

namespace CityCode
{
    class Program
    {
        static void Main(string[] args)
        {
            CityMap map = new CityMap();
            CityCode c1 = new CityCode("MH","Maharashtra");
            CityCode c2 = new CityCode("GJ","Gujarat");
            CityCode c3 = new CityCode("OD","Odisha");
            map.AddCityCode(c1);
            map.AddCityCode(c2);
            map.AddCityCode(c3);
            bool isToShow = true;
            while (isToShow)
            {
                Console.WriteLine("Press 1 for searching on exact CityCode you have :");
                Console.WriteLine("Press 2 if You know the starting character of the citycode :");
                
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Enter your choice :");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the CityCode :");
                        string inputCode=Convert.ToString(Console.ReadLine());
                        map.CheckCityCode(inputCode);
                        break;
                    case 2:
                        Console.WriteLine("Searching for.....");
                        string inputChar = Convert.ToString(Console.ReadLine());
                        map.CheckCityCodeWithChar(inputChar);
                        break;

                    default:
                        isToShow = false;
                        Console.WriteLine("Oops wrong input......try again..");
                        break;
                }

            }

        }
    }
}
