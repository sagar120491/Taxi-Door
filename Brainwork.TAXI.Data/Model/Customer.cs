using System.Collections.Generic;

namespace Brainwork.TAXI.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Status { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}
