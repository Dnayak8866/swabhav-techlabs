using System;
using System.Collections.Generic;
using System.Text;

namespace CityCode
{
    class CityCode
    {
        private string _cityCode;
        private string _description;

        public CityCode(string citycode,string desciption)
        {
            this._cityCode = citycode;
            this._description = desciption;
        }

        public string Code
        {
            get
            {
                return _cityCode;
            }
        }
        public string Desciption
        {
            get
            {
                return _description;
            }
        }
    }
}
