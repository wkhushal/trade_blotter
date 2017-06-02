namespace trade_blotter.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TradeBooking")]
    public partial class TradeBooking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TradeBookingId { get; set; }

        public int UserId { get; set; }

        public int TradeId { get; set; }

        [Required]
        [StringLength(100)]
        public string TradeStatus { get; set; }

        public virtual Trade Trade { get; set; }

        public virtual User User { get; set; }
    }
}
