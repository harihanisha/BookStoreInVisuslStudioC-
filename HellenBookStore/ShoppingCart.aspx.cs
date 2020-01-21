using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HellenBookStore
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            else
            {
                foreach (string name in Request.Form.AllKeys)
                {
                    if (name.StartsWith("Book"))
                    {
                        string ISBN = name.Substring(4);

                        List <ShoppingCartItem> shoppingCart = null;
                        if (Session["shoppingCart"] == null)
                        {
                            return;
                        }

                        else
                        {
                            shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
                            foreach ( ShoppingCartItem item in shoppingCart)
                            {
                                if(item.ISBN == ISBN)
                                {
                                    if (item.Qty == 1)
                                    {
                                        shoppingCart.Remove(item);
                                        
                                    }
                                    else
                                    {
                                        item.Qty -= 1;
                                    }
                                    Session["shoppingCart"] = shoppingCart;
                                    return;
                                }
                            }
                        }

                        }
                    }
                }
            }
        public string getShoppingCart()
        {
            string htmlStr = "";
            List<ShoppingCartItem> shoppingCart = (List < ShoppingCartItem >) Session["ShoppingCart"];
            if (shoppingCart == null || shoppingCart.Count==0)
            {
                LabelMessage.Text = "Yours shopping cart is empty";
                return "";
            }
            foreach (ShoppingCartItem  item in shoppingCart){


                string ISBN = item.ISBN;
                string Title = item.Title;
                decimal Price = item.Price;
                int Qty = item.Qty;
                decimal Total = item.Total;
                string Image = item.ImageName;
                htmlStr += "<tr><td>" + ISBN + "</td><td>" + Title + "</td> ";
                htmlStr += "<td>" + Price.ToString("c2") + "</td>";
                htmlStr += "<td>" + Qty.ToString() + "</td>";
                htmlStr += "<td>" + Total.ToString("c2") + "</td>";
                htmlStr += "<td><img src='Images/" + Image + "'  height = '100' width = '100' </ td > ";
                //htmlStr += "<td><input name='Book" + ISBN + "'  type = 'submit' value = 'Buy Now' /></ td > ";
                htmlStr += "<td><input name='Book" + ISBN + "'  type = 'submit' value = 'Remove' /></ td > ";

                htmlStr += "</tr>";

            }
            
            return htmlStr;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void ButtonCheckOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("CheckOut.aspx");
        }
    }
}