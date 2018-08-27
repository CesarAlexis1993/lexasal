namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemsRunningLow")]
    public partial class ItemsRunningLow
    {
        [Key]
        public int ItemRunningLowId { get; set; }

        [StringLength(50)]
        public string MenuType { get; set; }

        [StringLength(50)]
        public string ItemId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
