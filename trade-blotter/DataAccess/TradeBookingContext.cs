using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using trade_blotter.Models;

namespace trade_blotter.DataAccess
{
    public class TradeBookingContext : DbContext
    {
        public TradeBookingContext()
            : base("TradeBookingContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<TradeBooking> TradeBookings { get; set; }
        public DbSet<Trade> Trades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}