using System;
using System.Collections.Generic;
using System.Text;

namespace ContactApp
{
    [Serializable]
   public  class Contact
    {
        private string _name;
        private string _number;
        public Contact(string name,string number)
        {
            this._name = name;
            this._number = number;
        }

        public override string ToString()
        {
            return "Name :" + this._name
                + "\nMobile No :" + this._number
                +"\n.............................";
        }
    }
}
