using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HellenBookStore
{
    public class Order
    {

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }

        public Order(int orderId, int customerId, DateTime orderDate, decimal subTotal, decimal tax, decimal total)
        {

            OrderId = orderId;
            CustomerId = customerId;
            OrderDate = orderDate;
            SubTotal = subTotal;
            Tax = tax;
            Total = total;
        }
        public  override string  ToString()
        {

            return OrderId + " " + CustomerId + " " + OrderDate + " " + SubTotal + " " + Tax + " " + Total + " ";
        }

    }
}