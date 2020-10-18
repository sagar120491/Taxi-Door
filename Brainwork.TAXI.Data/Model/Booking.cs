using System;
using System.Collections.Generic;

namespace Brainwork.TAXI.Data
{
    public class Booking
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public decimal RequestAmount { get; set; }
        public decimal FinalAmount { get; set; }
        public int VendorId { get; set; }
        public int DriverId { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public Vendor Vendor { get; set; }
        public Driver Driver { get; set; }
        public Customer Customer { get; set; }

        public List<Bid> Bids { get; set; }
        public List<Fare> Fares { get; set; }
    }
}
