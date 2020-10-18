using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDoor.Data
{
    public class Vehicle
    {

        public int Id { get; set; }
        public string VehicleType { get; set; }
        public string  RegistrationNumber { get; set; }
        public string Image { get; set; }
        public string FuelType { get; set; }
        public string Status { get; set; }

        public int VendorId { get; set; }

        public Vendor Vendors { get; set; }
        public List<Bid> Bids { get; set; }
    }
}
