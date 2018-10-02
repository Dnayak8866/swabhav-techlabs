using System;
using System.Collections.Generic;
using System.Text;

namespace CityCode
{
    class CityMap
    {
        Dictionary<CityCode, CityCode> citymap = new Dictionary<CityCode, CityCode>();
        public void AddCityCode(CityCode c)
        {
            citymap.Add(c,c);

        }

        public void CheckCityCode(String input)
        {
            bool anyMatchFound = false;
            foreach (KeyValuePair<CityCode,CityCode> city in citymap)
            {
                if (input.Equals(city.Value.Code,StringComparison.CurrentCultureIgnoreCase))
                {
                    anyMatchFound = true;
                    Console.WriteLine(input + " stands for " + city.Value.Desciption);
                    break;
                }else
                {
                    anyMatchFound = false;
                }
            }

            if (!anyMatchFound)
            {
                Console.WriteLine("No match found......");
            }
        }

        public void CheckCityCodeWithChar(String inputChar)
        {
            foreach (KeyValuePair<CityCode,CityCode> city in citymap)
            {
                string description = city.Value.Desciption;
                for (int i=0;i<description.Length;i++)
                {
                    char c = description[i];
                    string descripchar = Convert.ToString(c);
                    if (inputChar.Equals(descripchar,StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("May br you are looking for.."+city.Value.Desciption);
                        break;
                    }
                }
            }
        }
    }
}
