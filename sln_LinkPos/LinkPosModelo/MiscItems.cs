namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MiscItems
    {
        [Key]
        public int MiscItemId { get; set; }

        public int? TicketId { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public double? Price { get; set; }

        public bool? isModifier { get; set; }

        public bool? PrintRemote { get; set; }

        public int? TaxRate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
