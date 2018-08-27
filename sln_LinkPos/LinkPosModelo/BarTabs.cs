namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BarTabs
    {
        [Key]
        public int BarTabId { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        public int? PreAuthTransactionId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? TicketId { get; set; }

        public double? Amount { get; set; }

        public double? BarTabNumber { get; set; }

        public bool? Hide { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
