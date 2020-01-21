using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HellenBookStore
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public string ISBN { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }

        public OrderItem(int orderId, string isbn, int qty, decimal price)
        {

            OrderId = orderId;
            ISBN = isbn;
            Qty = qty;
            Price = price;
        }

        public override string ToString()
        {

            return OrderId + " " + ISBN + " " + Qty + " " + Price + " ";
        }

    }
}