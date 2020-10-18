using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Principal;
using System.Text;

namespace TaxiDoor.Data
{
    public class Fare
    {

        public int Id { get; set; }
        public Decimal ExtraDistance { get; set; }
    
        public decimal RatePerExtraKM { get; set; }
        public decimal TotalAmount { get; set; }

        public decimal Commission { get; set; }


        public decimal Tax { get; set; }


        public int BookingId { get; set; }

        public Booking Bookings { get; set; }

    }



}
