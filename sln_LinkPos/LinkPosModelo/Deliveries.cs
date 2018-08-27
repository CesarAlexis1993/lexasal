namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Deliveries
    {
        [Key]
        public int DeliveryId { get; set; }

        public int? TicketId { get; set; }

        public int? UserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOut { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeIn { get; set; }

        public bool? Void { get; set; }

        public bool? Archived { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
