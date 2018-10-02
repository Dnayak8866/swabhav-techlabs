using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transactionApp
{
    class Merchant
    {
        private int _id;
        private string _name;
        private int _balance;

        public Merchant(int id)
        {
            _id = id;
          
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            }
        }
    }
}
