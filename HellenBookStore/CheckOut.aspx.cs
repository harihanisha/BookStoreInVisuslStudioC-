using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HellenBookStore
{
    public partial class CheckOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            decimal tax = 0;
            decimal total = 0;
            decimal subTotal = 0;
            List<ShoppingCartItem> shoppingCart = null;
            if (Session["shoppingCart"] == null)
            {
                return;
            }

            else
            {
                shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
                if (shoppingCart == null)
                {
                    LabelMessage.Text = "Your shopping cart is empty";
                    return;
                }

                foreach (ShoppingCartItem item in shoppingCart)
                {
                    subTotal += item.Total;

                }
                tax = subTotal * 0.05m;
                total = subTotal + tax;

                TextBoxTax.Text = tax.ToString("f2");
                TextBoxTotal.Text = total.ToString("f2");
                TextBoxSubTotal.Text = subTotal.ToString("f2");
            }
        }

        protected void ButtonShipOrder_Click(object sender, EventArgs e)
        {
            string firstName = TextBoxFirstName.Text;
            string lastName = TextBoxLastName.Text;
            string address = TextBoxAddress.Text;
            string phoneNumber = TextBoxPhoneNumber.Text;
            string email = TextBoxEmailAddress.Text;
            string creditCardNumber = TextBoxCreditCardNumber.Text;
            string shippingAddress = TextBoxShippingAddress.Text;
            decimal tax = decimal.Parse(TextBoxTax.Text);
            decimal total = decimal.Parse(TextBoxTotal.Text);
            decimal subTotal = decimal.Parse(TextBoxSubTotal.Text);
            Customer customer = new Customer(0, firstName + " " + lastName, address, phoneNumber, email);
            int customerId = DBMgr.insertCustomer(customer);
            Order order = new Order(0, customerId, DateTime.Now, subTotal, tax, total);
            int orderId = DBMgr.insertOrder(order);
            List<ShoppingCartItem> shoppingCart = null;
            if (Session["shoppingCart"] == null)
            {
                return;
            }

            else
            {
                shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
                if (shoppingCart == null)
                {
                    LabelMessage.Text = "Your shopping cart is empty";
                    return;
                }

                foreach (ShoppingCartItem item in shoppingCart)
                {
                    string ISBN = item.ISBN;
                    string Title = item.Title;
                    decimal Price = item.Price;
                    int Qty = item.Qty;
                    decimal Total = item.Total;
                    string Image = item.ImageName;
                    OrderItem orderItem = new OrderItem(orderId, ISBN, Qty, Price);
                    DBMgr.insertOrderItem(orderItem);

                }
            }
            Session["customerid"] = customerId;
            Session["orderid"] = orderId;
            Response.Redirect("Thankyou.aspx");

        }
    }
}