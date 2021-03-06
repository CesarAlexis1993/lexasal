namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InventoryItemAssignments
    {
        [Key]
        public int MenuRecipeId { get; set; }

        public int? ItemTypeId { get; set; }

        public int? ItemId { get; set; }

        public double? Quantity { get; set; }

        public int? InventoryId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
