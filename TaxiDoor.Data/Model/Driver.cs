using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDoor.Data
{
    public class Driver

    {

        public int Id { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String Mobile { get; set; }
        public String Email { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Address { get; set; }
        public String LicenceNumber { get; set; }
        public String AdharNumber { get; set; }
        public String PanNumber { get; set; }
        public string Status { get; set; }

        public int VendorId { get; set; }

        public Vendor Vendors { get; set; }
        public List<Booking> Bookings { get; set; }





    }
}
