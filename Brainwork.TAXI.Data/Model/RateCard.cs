namespace Brainwork.TAXI.Data
{
    public class RateCard
    {
        public int Id { get; set; }
        public string CarType { get; set; }
        public decimal RatePerKM { get; set; }
        public decimal NightAllowance { get; set; }
    }
}
