using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trade_blotter.Models
{
    public enum BuySell {
        Buy,
        Sell
    }

    public class Trade
    {
        public int TradeID { get; set; }
        public string Reference { get; set; }
        public BuySell BuySell { get; set; } 
        public decimal Lots { get; set; }
        public string Contract { get; set; }
        public DateTime TradeTime { get; set; }

        public virtual ICollection<TradeBooking> TradeBookings { get; set; }
    }
}