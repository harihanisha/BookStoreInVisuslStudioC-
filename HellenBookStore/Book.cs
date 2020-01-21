using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HellenBookStore
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int QtyOnHand { get; set; }

        public string ImageName { get; set; }


        public Book(string isbn, string title, string author, decimal price, int qtyonhand, string imageName)
        {

            ISBN = isbn;
            Title = title;
            Author = author;
            Price = price;
            QtyOnHand = qtyonhand;
            ImageName = imageName;

        }
        public override string ToString()
        {

            return ISBN + " " + Title + " " + Author + " " + Price + " " + QtyOnHand + " " + ImageName + "";

        }

    }
}