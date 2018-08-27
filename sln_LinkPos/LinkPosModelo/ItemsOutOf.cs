namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemsOutOf")]
    public partial class ItemsOutOf
    {
        [Key]
        public int ItemOutOfId { get; set; }

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
