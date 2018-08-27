namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RemoteDisplayLog")]
    public partial class RemoteDisplayLog
    {
        public int RemoteDisplayLogId { get; set; }

        public int? RemoteDisplayId { get; set; }

        public int? TicketId { get; set; }

        public bool? isOptional { get; set; }

        public int? Quantity { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public double? Price { get; set; }

        public bool? isBumped { get; set; }

        public bool? isDeleted { get; set; }

        public int? ItemId { get; set; }

        public int? ItemTypeId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? SendDateTime { get; set; }

        public int? GuestId { get; set; }

        public int? OrderTypeId { get; set; }

        public int? TicketDetailsId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BumpedDateTime { get; set; }

        [StringLength(20)]
        public string OrderInstruction { get; set; }

        [StringLength(20)]
        public string CustomerName { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
