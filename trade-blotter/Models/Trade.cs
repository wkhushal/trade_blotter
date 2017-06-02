namespace trade_blotter.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trade")]
    public partial class Trade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trade()
        {
            TradeBookings = new HashSet<TradeBooking>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TradeId { get; set; }

        [Required]
        [StringLength(100)]
        public string BuySell { get; set; }

        [Required]
        [StringLength(100)]
        public string Reference { get; set; }

        [Required]
        [StringLength(100)]
        public string Contract { get; set; }

        public int Lots { get; set; }

        public decimal Price { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TradeTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TradeBooking> TradeBookings { get; set; }
    }
}
