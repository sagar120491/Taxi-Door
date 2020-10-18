namespace Brainwork.TAXI.Data
{
    public class Fare
    {
        public int Id { get; set; }
        public int ExtraDistance { get; set; }
        public decimal RatePerExtraKM { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Commission { get; set; }
        public decimal TaxGST { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
