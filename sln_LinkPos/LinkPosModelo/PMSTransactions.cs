namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PMSTransactions
    {
        [Key]
        public int PMSTransactionId { get; set; }

        public int? TicketId { get; set; }

        public int? TransactionType { get; set; }

        public int? TransactionResult { get; set; }

        public double? Amount { get; set; }

        public bool? Void { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? Archived { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Tickets Tickets { get; set; }
    }
}
