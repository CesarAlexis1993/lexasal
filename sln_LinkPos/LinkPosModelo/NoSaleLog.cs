namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NoSaleLog")]
    public partial class NoSaleLog
    {
        public int NoSaleLogId { get; set; }

        public int? UserId { get; set; }

        public int? NoSaleReasonId { get; set; }

        public int? PosStationId { get; set; }

        public int? CashDrawerId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
