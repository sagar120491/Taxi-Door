using System.Collections.Generic;

namespace Brainwork.TAXI.Data
{
   public class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LicenceNumber { get; set; }
        public string AdharNumber { get; set; }
        public string PAN { get; set; }
        public string Status { get; set; }
        public int AccountId { get; set; }
        public int VendorId { get; set; }

        public Account Account { get; set; }
        public Vendor Vendor { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}
