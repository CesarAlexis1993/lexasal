namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RemovedItems
    {
        [Key]
        public int DeletedItemId { get; set; }

        public int? ItemId { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public int? ItemQty { get; set; }

        public double? ItemPrice { get; set; }

        [StringLength(50)]
        public string ItemType { get; set; }

        public int? UserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? TicketId { get; set; }

        public int? DeletedItemReasonId { get; set; }

        [StringLength(50)]
        public string DeletedItemReason { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
