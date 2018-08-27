namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryUsage")]
    public partial class InventoryUsage
    {
        public int InventoryUsageId { get; set; }

        public int? InventoryItemId { get; set; }

        public int? TicketDetailsId { get; set; }

        public double? QtyUsed { get; set; }

        public double? Cost { get; set; }

        public int? UserID { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
