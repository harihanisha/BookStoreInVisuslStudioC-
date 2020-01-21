using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HellenBookStore
{
    public class ShoppingCartItem
    {
       
        
            public string ISBN { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }
            public int Qty { get; set; }

            public decimal Total { get; set; }

            public string ImageName { get; set; }


            public ShoppingCartItem(string isbn, string title,  decimal price, int qty,decimal total, string imageName)
            {

                ISBN = isbn;
                Title = title;
                Price = price;
                Qty = qty;
                Total = total;
                ImageName = imageName;

            }
            public override string ToString()
            {

                return ISBN + " " + Title + " "  + " " + Price + " " + Qty + " " + Total +" " + ImageName + "";

            }

        }
    }

