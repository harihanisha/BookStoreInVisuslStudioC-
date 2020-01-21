using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HellenBookStore
{
    public class DBMgr
    {
        const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BookStore.mdf;Integrated Security = True";

        public static Book GetBook(string isbn)
        {
            SqlConnection thisConnection = new SqlConnection(connectionString);
            SqlCommand thisCommand = thisConnection.CreateCommand();
            thisCommand.CommandText = "SELECT * from Book WHERE ISBN ='" + isbn + "'";
            //thisCommand.CommandText = "SELECT * from Book";
            thisConnection.Open();
            SqlDataReader reader = thisCommand.ExecuteReader();
            Book book = null;
            while (reader.Read())
            {
                string ISBN = reader.GetString(0);
                string Title = reader.GetString(1);
                string Author = reader.GetString(2);
                decimal Price = reader.GetDecimal(3);
                int qty = reader.GetInt32(4);
                string Image = reader.GetString(5);
                book = new Book(ISBN, Title, Author, Price, qty, Image);

            }
            thisConnection.Close();
            return book;
        }

        public static int insertOrder(Order order)
        {
            int newid = 0;
            try
            {


                String query = "INSERT INTO [Order] (customerid,orderdate,subtotal,tax,total) VALUES (@customerid,@orderdate, @subtotal,@tax,@total)";
                SqlConnection thisConnection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, thisConnection);
                thisConnection.Open();
                command.Parameters.AddWithValue("@customerid", order.CustomerId);
                command.Parameters.AddWithValue("@orderdate", order.OrderDate);
                command.Parameters.AddWithValue("@subtotal", order.SubTotal);
                command.Parameters.AddWithValue("@tax", order.Tax);
                command.Parameters.AddWithValue("@total", order.Total);

                command.ExecuteNonQuery();
                query = "SELECT @@IDENTITY";
                command = new SqlCommand(query, thisConnection);
                string s = command.ExecuteScalar().ToString();
                newid = int.Parse(s);
                thisConnection.Close();
            }
            catch(Exception ex)
            {

            }
            return newid;
        }
        public static int insertCustomer(Customer customer)
        {
            int newid = 0;
            try
            {


                String query = "INSERT INTO dbo.Customer (name,address,phone,email) VALUES (@name,@address,@phone,@email)";
                SqlConnection thisConnection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(query, thisConnection);
                thisConnection.Open();
                command.Parameters.AddWithValue("@name", customer.Name);
                command.Parameters.AddWithValue("@address", customer.Address);
                command.Parameters.AddWithValue("@phone", customer.Phone);
                command.Parameters.AddWithValue("@email", customer.Email);

                command.ExecuteNonQuery();
                query = "SELECT @@IDENTITY";

                command = new SqlCommand(query, thisConnection);
                string s = command.ExecuteScalar().ToString();
                newid = int.Parse(s);
                thisConnection.Close();
            }
            catch(Exception ex)
            {

            }
            return newid;
        }
        public static int insertOrderItem(OrderItem orderitem)
        {
            int newid = 0;
            try
            {

                String query = "INSERT INTO dbo.OrderItem (orderid,isbn,qty,price) VALUES (@orderid,@isbn,@qty, @price)";
                SqlConnection thisConnection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(query, thisConnection);
                thisConnection.Open();
                command.Parameters.AddWithValue("@orderid", orderitem.OrderId);
                command.Parameters.AddWithValue("@isbn", orderitem.ISBN);
                command.Parameters.AddWithValue("@qty", orderitem.Qty);
                command.Parameters.AddWithValue("@price", orderitem.Price);

                command.ExecuteNonQuery();
                query = "SELECT @@IDENTITY";
                command = new SqlCommand(query, thisConnection);
                string s = command.ExecuteScalar().ToString();
                newid = int.Parse(s);

                thisConnection.Close();
            }
            catch(Exception ex)
            {

            }
            return newid;
        }
    }
}