using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using trade_blotter.Models;

namespace trade_blotter.DataAccess
{
    public class TradeBookingInitializer : CreateDatabaseIfNotExists<TradeBookingContext>
    {
        public override void InitializeDatabase(TradeBookingContext context)
        {
            //var Users = new List<User>
            //{
            //    new User{ Id=1,FirstName="Waqas",LastName="Khushal",UserRole="Admin", LUDateTime=DateTime.UtcNow },
            //    new User{ Id=2,FirstName="Tom",LastName="Harry",UserRole="Trader",LUDateTime=DateTime.UtcNow}
            //};

            //Users.ForEach(u => context.Users.Add(u));

            //context.SaveChanges();

            //var Trades = new List<Trade>
            //{
            //    new Trade{TradeId=1, BuySell="Buy",Reference="COAL DEC-14", Contract="ICE-COALDEC-14",Lots=25,TradeTime=DateTime.UtcNow,Price=5 },
            //    new Trade{TradeId=2, BuySell="Buy",Reference="COAL JAN-15", Contract="ICE-COALJAN-15",Lots=25,TradeTime=DateTime.UtcNow,Price=5 },
            //    new Trade{TradeId=3, BuySell="Buy",Reference="COAL FEB-15", Contract="ICE-COALFEB-15",Lots=25,TradeTime=DateTime.UtcNow,Price=5 },
            //};

            //Trades.ForEach(t => context.Trades.Add(t));

            //context.SaveChanges();

            //var tradeBookings = new List<TradeBooking>
            //{
            //    new TradeBooking{ TradeBookingId=1,UserId=2,TradeId=1, TradeStatus="Booked"},
            //    new TradeBooking{ TradeBookingId=2,UserId=2,TradeId=2, TradeStatus="Pending"},
            //    new TradeBooking{ TradeBookingId=3,UserId=2,TradeId=3, TradeStatus="Cancelled"},
            //};

            //tradeBookings.ForEach(b => context.TradeBookings.Add(b));
            //context.SaveChanges();
        }
    }
}