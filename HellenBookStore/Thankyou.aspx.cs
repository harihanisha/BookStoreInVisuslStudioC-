using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HellenBookStore
{
    public partial class Thankyou : System.Web.UI.Page
    {
        const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BookStore.mdf;Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["customerid"] == null || Session["orderid"] ==null)
                return;

            int customerId = (int)Session["customerid"];
            int orderId = (int)Session["orderid"];

            //open connection
            SqlConnection thisConnection = new SqlConnection(connectionString);
            SqlCommand thisCommand = thisConnection.CreateCommand();

            //show customers in data grid
            thisCommand.CommandText = "SELECT * from customer where customerid = " + customerId;
            thisConnection.Open();
          
            thisCommand.CommandType = CommandType.Text;
           
            SqlDataAdapter da = new SqlDataAdapter(thisCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();


            //show order in data grid
            thisCommand.CommandText = "SELECT * from [order] WHERE CUSTOMERID = " + customerId;
          

            thisCommand.CommandType = CommandType.Text;

            SqlDataAdapter da2 = new SqlDataAdapter(thisCommand);
              DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            GridView2.DataSource = dt2;
            GridView2.DataBind();


            //show orderItems in data grid
            thisCommand.CommandText = "SELECT * from orderItem where orderid = " + orderId;
           

            thisCommand.CommandType = CommandType.Text;

            SqlDataAdapter da3 = new SqlDataAdapter(thisCommand);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            GridView3.DataSource = dt3;
            GridView3.DataBind();

            //close connection
            thisConnection.Close();

        }

        protected void ButtonAnotherOrder_Click(object sender, EventArgs e)
        {
            
            Session["shoppingCart"] = null;
            Session["customerid"] = null;
            Session["orderid"] = null;

            Response.Redirect("Home.aspx");

        }
    }
}