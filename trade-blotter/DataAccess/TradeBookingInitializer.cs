using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using trade_blotter.Models;

namespace trade_blotter.DataAccess
{
    public class TradeBookingInitializer : DropCreateDatabaseIfModelChanges<TradeBookingContext>
    {
        public override void InitializeDatabase(TradeBookingContext context)
        {
            var Users = new List<User>
            {
                new User{ ID=1,FirstName="Waqas",LastName="Khushal",UserRole=Role.Admin, LUDateTime=DateTime.UtcNow },
                new User{ ID=2,FirstName="Tom",LastName="Harry",UserRole=Role.Trader,LUDateTime=DateTime.UtcNow}
            };

            Users.ForEach(u => context.Users.Add(u));

            context.SaveChanges();

            var Trades = new List<Trade>
            {
                new Trade{TradeID=1, BuySell=BuySell.Buy,Reference="COAL DEC-14", Contract="ICE-COALDEC-14",Lots=25,TradeTime=DateTime.UtcNow },
                new Trade{TradeID=2, BuySell=BuySell.Buy,Reference="COAL JAN-15", Contract="ICE-COALJAN-15",Lots=25,TradeTime=DateTime.UtcNow },
                new Trade{TradeID=3, BuySell=BuySell.Buy,Reference="COAL FEB-15", Contract="ICE-COALFEB-15",Lots=25,TradeTime=DateTime.UtcNow },
            };

            Trades.ForEach(t => context.Trades.Add(t));

            context.SaveChanges();

            var tradeBookings = new List<TradeBooking>
            {
                new TradeBooking{ TradeBookingID=1,UserId=2,TradeId=1, TradeStatus=TradeStatus.Booked},
                new TradeBooking{ TradeBookingID=2,UserId=2,TradeId=2, TradeStatus=TradeStatus.Pending},
                new TradeBooking{ TradeBookingID=3,UserId=2,TradeId=3, TradeStatus=TradeStatus.Cancelled},
            };

            tradeBookings.ForEach(b => context.TradeBookings.Add(b));
            context.SaveChanges();
        }
    }
}