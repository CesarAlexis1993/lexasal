namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CashDrops
    {
        [Key]
        public int CashDropId { get; set; }

        public int? UserId { get; set; }

        public int? TerminalId { get; set; }

        public int? CashDrawerId { get; set; }

        public double? Amount { get; set; }

        public bool? DrawerReset { get; set; }

        public bool? Archived { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? DrawerResetID { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
