namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TabletServerCustomerReceipts
    {
        [Key]
        [Column(Order = 0)]
        public int TabletServerCustomerReceiptID { get; set; }

        public int? TicketId { get; set; }

        public double? PrinterID { get; set; }

        public DateTime? TimeDateStamp { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
