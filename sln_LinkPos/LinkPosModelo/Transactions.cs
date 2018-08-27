namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transactions
    {
        [Key]
        public int TransactionID { get; set; }

        public int? TransactionTypeId { get; set; }

        public int? TicketID { get; set; }

        public int? UserId { get; set; }

        public int? TerminalID { get; set; }

        public int? CashDrawerID { get; set; }

        public double? Amount { get; set; }

        public double? GratuityAmount { get; set; }

        public double? AmountTendered { get; set; }

        public bool? Void { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? BankCheckNumber { get; set; }

        public bool? Archived { get; set; }

        public bool? DrawerReset { get; set; }

        public int? ExtAuthCode { get; set; }

        public int? DrawerResetID { get; set; }

        [StringLength(100)]
        public string ExtendedInfo { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Tickets Tickets { get; set; }

        public virtual Users Users { get; set; }

        public virtual TransactionTypes TransactionTypes { get; set; }
    }
}
