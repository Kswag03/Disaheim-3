using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim1
{
    public class Book
    {
        public string ItemID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }





        public Book(string itemid) :this (itemid, null)
        {
        }

        public Book(string itemid, string title): this(itemid, title, 0.0)
        {
        }

        public Book(string itemid, string title, double price)
        {
            ItemID = itemid;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemID}, Title: {Title}, Price: {Price}";
        }
    }

    
}
