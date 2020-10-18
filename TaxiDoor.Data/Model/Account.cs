using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDoor.Data
{
    public class Account
    {

        public int Id { get; set; }

        public Decimal AvailableBalance { get; set; }

        public decimal Penalty { get; set; }
        public decimal BonusAmount { get; set; }

        public decimal TotalBonus { get; set; }


        public DateTime Date { get; set; }

    }
}
