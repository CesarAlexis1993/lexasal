namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DrawerCounts
    {
        [Key]
        public int DrawerCountId { get; set; }

        public int? DrawerResetId { get; set; }

        public int? TerminalId { get; set; }

        public int? CashDrawerId { get; set; }

        public int? UserID { get; set; }

        public int? Status { get; set; }

        public int? DrawerCountTypeId { get; set; }

        public double? CountTotal { get; set; }

        public int? ReferenceNumber { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
