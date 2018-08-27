namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryAdjust")]
    public partial class InventoryAdjust
    {
        public int InventoryAdjustId { get; set; }

        public int? InventoryItemId { get; set; }

        public double? QtyAdjust { get; set; }

        public double? CostAdjust { get; set; }

        public int? InventoryAdjustReasonId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
