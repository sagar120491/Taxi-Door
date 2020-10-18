using System.Collections.Generic;

namespace Brainwork.TAXI.Data
{
    public class Vendor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string AdharNumber { get; set; }
        public string PAN { get; set; }
        public string Status { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public List<Booking> Booking { get; set; }
    }
}
