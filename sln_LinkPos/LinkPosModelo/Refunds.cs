namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Refunds
    {
        [Key]
        public int RefundId { get; set; }

        public int? RefundReasonId { get; set; }

        public int? UserId { get; set; }

        public int? TerminalId { get; set; }

        public int? CashDrawerId { get; set; }

        public double? RefundAmount { get; set; }

        public bool? DrawerReset { get; set; }

        public bool? Archived { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? PaymentTypeId { get; set; }

        public int? TicketId { get; set; }

        public int? TicketDetailsId { get; set; }

        public int? RefundType { get; set; }

        public bool? Void { get; set; }

        public int? DrawerResetID { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
