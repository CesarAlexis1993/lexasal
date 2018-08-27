namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DrawerResetLog")]
    public partial class DrawerResetLog
    {
        [Key]
        public int DrawerResetId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? TerminalId { get; set; }

        public int? CashDrawerId { get; set; }

        public double? CashInDrawer { get; set; }

        public int? TicketCount { get; set; }

        public int? UserID { get; set; }

        public double? OverShortAmount { get; set; }

        public string TextReport { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Users Users { get; set; }
    }
}
