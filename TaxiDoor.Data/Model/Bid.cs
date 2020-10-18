using System;
using System.Collections.Generic;
using System.Text;


namespace TaxiDoor.Data
{
    public class Bid
    {

        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }

        public int BookingId { get; set; }
        public int VehicleId { get; set; }


        public Booking Bookings{ get; set; }
        public Vehicle Vehicles { get; set; }

        
    }

}
