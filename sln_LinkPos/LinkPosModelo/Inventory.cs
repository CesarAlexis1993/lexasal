namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        public int InventoryId { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public int? InventoryCategoryId { get; set; }

        [StringLength(200)]
        public string ItemNotes { get; set; }

        public int? AisleId { get; set; }

        public int? RetailAisleId { get; set; }

        public int? SupplierId { get; set; }

        public int? SecondarySupplierId { get; set; }

        public bool? Disable { get; set; }

        public int? InventoryUnitId { get; set; }

        public double? CaseCost { get; set; }

        public int? ItemsPerPack { get; set; }

        public int? PacksPerCase { get; set; }

        [StringLength(50)]
        public string UnitSKU { get; set; }

        [StringLength(50)]
        public string PackSKU { get; set; }

        [StringLength(50)]
        public string CaseSKU { get; set; }

        public double? ReorderLevel { get; set; }

        public double? MaximumQuantity { get; set; }

        public double? CurrentQuantityEstimate { get; set; }

        public double? CurrentQuantityActual { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? InventoryTypeId { get; set; }

        public double? QBCurrentDayUsage { get; set; }

        public bool? CarryOutOnly { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual InventoryCategories InventoryCategories { get; set; }

        public virtual InventoryAisles InventoryAisles { get; set; }

        public virtual InventoryUnits InventoryUnits { get; set; }

        public virtual Suppliers Suppliers { get; set; }
    }
}
