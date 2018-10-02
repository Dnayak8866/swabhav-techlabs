using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LineItem> orderedItems = new List<LineItem>();
            orderedItems.Add(new LineItem("Tshirt", 123, 500, 2));
            orderedItems.Add(new LineItem("jeans", 111, 900, 2));
            orderedItems.Add(new LineItem("joggers", 133, 1000, 3));
            orderedItems.Add(new LineItem("Jacket", 101, 1000, 3));

            foreach (LineItem item in orderedItems)
            {
                Console.WriteLine("Item Name:" + item.Name
                    + "\nItem ID :" + item.Id
                    + "\nQuantity :" + item.Quantity
                    + "\nPrice :" + item.Price
                    + "\nTotal Cost :" + item.TotalCost());
                Console.WriteLine("--------------------------------------------");
            }

        }
    }
}
