using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TaxiDoor.Data
{
    public class Booking
    {

        public int Id { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }

        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public Decimal RequestedAmount { get; set; }
        public Decimal FinalAmount { get; set; }
        public string Status { get; set; }

        public int CustomerId { get; set; }
        public int VendorId { get; set; }
        public int DriverId { get; set; }
        public Customer Customers { get; set; }
        public Vendor Vendors { get; set; }
        public Driver Drivers { get; set; }

        public List<Bid> Bids { get; set; }
        public List<Fare> Fares { get; set; }

    }
}
