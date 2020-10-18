using System.Collections.Generic;

namespace Brainwork.TAXI.Data
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string CarType { get; set; }
        public string RegistrationNumber { get; set; }
        public string Image { get; set; }
        public string FuelType { get; set; }
        public int VendorId { get; set; }
        public string Status { get; set; }
        public Vendor Vendor { get; set; }
        public List<Bid> Bids { get; set; }
    }
}
