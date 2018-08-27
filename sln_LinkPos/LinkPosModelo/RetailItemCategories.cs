namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RetailItemCategories
    {
        [Key]
        public int RetailCategoryId { get; set; }

        public bool? Disable { get; set; }

        public bool? BulkItem { get; set; }

        [StringLength(50)]
        public string ItemCategory { get; set; }

        [StringLength(50)]
        public string ItemSubCategory { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
