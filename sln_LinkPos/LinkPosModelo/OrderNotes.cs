namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderNotes
    {
        public int Id { get; set; }

        public int? TicketId { get; set; }

        public string Note { get; set; }

        public int? PrinterId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateTimeStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
