namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LoyaltyCardTransactions
    {
        [Key]
        public int LoyaltyCardTransactionId { get; set; }

        public int? LoyaltyCardId { get; set; }

        public int? TicketId { get; set; }

        public double? Amount { get; set; }

        public int? UserId { get; set; }

        public int? TerminalId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public bool? Void { get; set; }

        public int? VoidByUserId { get; set; }

        public bool? Archived { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
