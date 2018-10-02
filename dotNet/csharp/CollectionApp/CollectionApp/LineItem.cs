using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionApp
{
    class LineItem
    {
        private int _id;
        private int _quantity;
        private string _name;
        private double _price;

        public LineItem(string name,int id,double price, int quantity)
        {
            this._name = name;
            this._id = id;
            this._quantity = quantity;
            this._price = price;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }

        public double TotalCost()
        {
            double totalCost;
            totalCost= _quantity * _price;
            return totalCost;
        }
    }
}
