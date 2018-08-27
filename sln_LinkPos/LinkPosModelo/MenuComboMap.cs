namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenuComboMap")]
    public partial class MenuComboMap
    {
        public int MenuComboMapId { get; set; }

        public int? MenuComboId { get; set; }

        public int? MenuItemId { get; set; }

        public int? Qty { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual MenuComboDefinitions MenuComboDefinitions { get; set; }

        public virtual RegularMenu RegularMenu { get; set; }
    }
}
