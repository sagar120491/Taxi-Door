namespace Brainwork.TAXI.Data
{
    public class Bid
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int VehicleId { get; set; }
        public int BookingId { get; set; }
        public string Status { get; set; }
        public Vehicle Vehicle { get; set; }
        public Booking Booking { get; set; }
    }
}
