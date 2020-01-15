using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSys
{
    public class Customer
    {
        //Fields

        //Properties
        //Instance Properties
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Prefix { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        //public int Phone { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //Static Properties
        public static int TotalCustomers { get; set; }

        public static string DELIM = ",";

        //---Constructors ----

        /// <summary>
        /// Creates new customer record with empty values, adds count to TotalCustomers
        /// </summary>
        public Customer()
        {
            TotalCustomers++;
        }

        /// <summary>
        /// Creates new customer record with ID number supplied
        /// </summary>
        /// <param name="customerId">Unique identier to create new customer record</param>
        public Customer(int customerId)
        {
            CustomerId = customerId;
            TotalCustomers++;
        }

        public override string ToString()
        {
            return string.Join(DELIM, new object[] { CustomerId, LastName, FirstName, Prefix, Gender, Address, City, State, Zip, Phone, Email });
        }
    }
}
