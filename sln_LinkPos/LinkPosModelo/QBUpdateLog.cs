namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QBUpdateLog")]
    public partial class QBUpdateLog
    {
        public int QBUpdateLogId { get; set; }

        public int? UpdateType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BusinessDayStart { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BusinessDayEnd { get; set; }

        public int? QBReceiptId { get; set; }

        public int? StatusCode { get; set; }

        [StringLength(200)]
        public string StatusDescription { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        [StringLength(50)]
        public string TxnId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
