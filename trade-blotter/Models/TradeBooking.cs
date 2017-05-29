using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trade_blotter.Models
{
    public enum TradeStatus {
        Pending,
        Booked,
        Cancelled
    }

    public class TradeBooking
    {
        public int TradeBookingID { get; set; }
        public int UserId { get; set; }
        public int TradeId { get; set; }
        public TradeStatus? TradeStatus { get; set; }

        public User User { get; set; }
        public Trade Trade { get; set; }
    }
}