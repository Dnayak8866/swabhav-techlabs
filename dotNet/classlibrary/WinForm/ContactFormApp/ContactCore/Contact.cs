using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore
{
    [Serializable]
    public class Contact
    {
        private string _name;
        private string _number;
        public Contact(string name, string number)
        {
            this._name = name;
            this._number = number;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Number
        {
            get
            {
                return _number;
            }
        }
        public override string ToString()
        {
            return "Name :" + this._name
                + "\nMobile No :" + this._number
                + "\n.............................";
        }
    }
}
