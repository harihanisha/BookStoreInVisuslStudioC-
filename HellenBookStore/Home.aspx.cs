using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HellenBookStore
{

    public partial class WebForm1 : System.Web.UI.Page
    {


        const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BookStore.mdf;Integrated Security = True";

        private List <ShoppingCartItem> shoppingCart;
        protected void Page_Load(object sender, EventArgs e)
        {

            
                if (Session["shoppingCart"] == null)
                {
                    shoppingCart = new List<ShoppingCartItem>();
                    Session["shoppingCart"] = shoppingCart;
                }
                else
                {
                    shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
                }

               
                
                LabelShoppingCart.Text = "You have " + shoppingCart.Count().ToString() + " items in your shopping cart";
                if (IsPostBack)
                 {

            
                foreach (string name in Request.Form.AllKeys)
                {


                    if (name.StartsWith("Book"))
                    {
                        string ISBN = name.Substring(4);
                        Book book = DBMgr.GetBook(ISBN);
                        if(book != null)
                        { 
                            
                                                    
                            ShoppingCartItem item = new ShoppingCartItem( book.ISBN,book.Title,book.Price,1,book.Price,book.ImageName);
                            
                            

                        foreach (ShoppingCartItem item2 in shoppingCart)
                            {
                                if (item2.ISBN == ISBN)
                                {
                                    
                                 
                                        item2.Qty += 1;
                                     Session["shoppingCart"] = shoppingCart;
                                    return;
                                    
                                }
                            }
                            shoppingCart.Add(item);
                            LabelShoppingCart.Text = "You have " + shoppingCart.Count().ToString() + " items in your shopping cart";
                        }
                    }

                }

            }
        }
        
        
        public string getBookInfo()
        {
            string htmlStr = "";
            SqlConnection thisConnection = new SqlConnection(connectionString);
            SqlCommand thisCommand = thisConnection.CreateCommand();
            thisCommand.CommandText = "SELECT * from Book";
            thisConnection.Open();
            SqlDataReader reader = thisCommand.ExecuteReader();

            while (reader.Read())
            {
                string ISBN = reader.GetString(0);
                string Title = reader.GetString(1);
                string Author = reader.GetString(2);
                decimal Price = reader.GetDecimal(3);
                string Image = reader.GetString(5);
                htmlStr += "<tr><td>" + ISBN + "</td><td>" + Title + "</td><td>" + Author + "</td>";
                htmlStr += "<td>" + Price.ToString("c2") + "</td>";
                htmlStr += "<td><img src='Images/" + Image + "'  height = '100' width = '100' </ td > ";
                htmlStr += "<td><input name='Book" + ISBN + "'  type = 'submit' value = 'Buy Now' /></ td > ";
                htmlStr += "</tr>";

            }
            thisConnection.Close();
            return htmlStr;
        }

        protected void ButtonViewShoppingCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}