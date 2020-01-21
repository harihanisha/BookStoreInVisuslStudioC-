using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HellenBookStore
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Customer(int id, string name, string address, string phone, string email)
        {

            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {

            return Id + " " + Name + " " + Address + " " + Phone + " " + Email + " ";
        }

    }
}