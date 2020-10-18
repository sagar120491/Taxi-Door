using System;
using System.Collections.Generic;

namespace Brainwork.TAXI.Data
{
    public class Account
    {
        public int Id { get; set; }
        public decimal AvailableBalance { get; set; }
        public decimal Penalty { get; set; }
        public decimal BonusAmount { get; set; }
        public decimal TotalBonus { get; set; }
        public DateTime Date { get; set; }
        public List<Driver> Drivers { get; set; }
    }
}
