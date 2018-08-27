namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DiscountAssignments
    {
        [Key]
        public int DiscountAssignmentId { get; set; }

        public int? DiscountId { get; set; }

        public int? MenuType { get; set; }

        public int? ItemId { get; set; }

        public int? Qty { get; set; }

        public bool? Mandatory { get; set; }

        public bool? IncludeModifiers { get; set; }

        public int? ItemType { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Discounts Discounts { get; set; }
    }
}
