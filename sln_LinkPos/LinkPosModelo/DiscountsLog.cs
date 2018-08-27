namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiscountsLog")]
    public partial class DiscountsLog
    {
        [Key]
        public int DiscountLogId { get; set; }

        public int? DiscountId { get; set; }

        public int? TicketID { get; set; }

        public int? TotalItems { get; set; }

        public double? TotalAmount { get; set; }

        public int? TaxRateId { get; set; }

        public int? UserID { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Tickets Tickets { get; set; }
    }
}
