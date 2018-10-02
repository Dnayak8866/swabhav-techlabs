using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionApp
{
    public static class StringExtension
    {
        public static string Swabhav(this string str)
        {
          
            return str ;
        }
        public static string ToUpperCase(this string str)
        {
            return str.ToUpper();
        }
    }
}
