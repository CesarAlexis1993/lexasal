namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiftCardTransactions
    {
        [Key]
        public int TransactionID { get; set; }

        [StringLength(200)]
        public string GiftCardStripe { get; set; }

        public int? UserID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public double? SaleAmount { get; set; }

        public double? AddValueAmount { get; set; }

        public bool? Void { get; set; }

        [StringLength(200)]
        public string VoidReason { get; set; }

        public int? TicketId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
