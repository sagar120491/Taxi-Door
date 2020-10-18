using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace TaxiDoor.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String Mobile { get; set; }
        public String Email { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }

        public String Status { get; set; }
        public List<Booking> Bookings { get; set;}


    }

}
