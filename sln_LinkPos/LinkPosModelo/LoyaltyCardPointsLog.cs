namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoyaltyCardPointsLog")]
    public partial class LoyaltyCardPointsLog
    {
        [Key]
        public int LoyaltyCardLogId { get; set; }

        public int? LoyaltyCardId { get; set; }

        public int? TicketId { get; set; }

        public int? TicketDetailsId { get; set; }

        public int? MenuTypeId { get; set; }

        public int? MenuItemId { get; set; }

        public int? MenuItemQty { get; set; }

        public int? MenuItemPoints { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public bool? Redeemed { get; set; }

        public int? LocationId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
