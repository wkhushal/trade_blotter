using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trade_blotter.Models
{
    public enum Role
    {
        Admin,
        MiddleOffice,
        Clearing,
        Trader
    }

    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LUDateTime { get; set; }
        public Role? UserRole { get; set; }

        public virtual ICollection<TradeBooking> TradeBookings { get; set; }
    }
}