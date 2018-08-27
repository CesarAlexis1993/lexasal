namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryReceived")]
    public partial class InventoryReceived
    {
        public int InventoryReceivedId { get; set; }

        public int? InventoryItemId { get; set; }

        public double? QtyReceived { get; set; }

        public double? QtyRemaining { get; set; }

        public double? UnitCost { get; set; }

        public int? UserId { get; set; }

        public int? SupplierId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        [StringLength(50)]
        public string InvoiceNumber { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
