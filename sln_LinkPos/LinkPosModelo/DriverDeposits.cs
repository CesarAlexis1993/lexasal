namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DriverDeposits
    {
        [Key]
        public int DriverDepositId { get; set; }

        public int? UserID { get; set; }

        public int? TerminalId { get; set; }

        public int? CashDrawerId { get; set; }

        public bool? Archived { get; set; }

        public bool? DrawerReset { get; set; }

        public double? Amount { get; set; }

        public bool? Void { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public bool? EndShift { get; set; }

        public int? DrawerResetID { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
