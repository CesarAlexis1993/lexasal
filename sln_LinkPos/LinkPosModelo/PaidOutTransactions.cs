namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaidOutTransactions
    {
        [Key]
        public int PaidOutId { get; set; }

        public int? PaidOutVendorId { get; set; }

        public int? PaidOutReasonId { get; set; }

        public double? PaidOutAmount { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? TerminalID { get; set; }

        public int? CashDrawerId { get; set; }

        public bool? Void { get; set; }

        public int? UserId { get; set; }

        public bool? DrawerReset { get; set; }

        public bool? Archived { get; set; }

        public int? DrawerResetID { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
