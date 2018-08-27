namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerAccountTransactions
    {
        [Key]
        public int TransactionId { get; set; }

        public int? CustomerAccountId { get; set; }

        public int? CustomerId { get; set; }

        public double? SaleAmount { get; set; }

        public double? DepositAmount { get; set; }

        public int? UserId { get; set; }

        public int? TicketId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public bool? Void { get; set; }

        [StringLength(50)]
        public string VoidReason { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
