namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrepTicketLog")]
    public partial class PrepTicketLog
    {
        [Key]
        public int PrepTicketId { get; set; }

        public int? TicketId { get; set; }

        public string PrepText { get; set; }

        public int? PrepPrinterId { get; set; }

        public int? ReprintCount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
