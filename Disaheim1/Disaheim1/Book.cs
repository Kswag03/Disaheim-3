using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim1
{
    public class Book : Merchandise
    {
       
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
            ItemId = itemid;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }

    
}
