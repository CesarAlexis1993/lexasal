namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerBookings
    {
        [Key]
        public int CustomerBookingID { get; set; }

        public int? CustomerId { get; set; }

        public int? nBCh { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BookingDate { get; set; }

        public bool? cbSk { get; set; }

        [StringLength(50)]
        public string cbTableID { get; set; }

        public int? nOver { get; set; }

        public int? nUnder { get; set; }

        [StringLength(200)]
        public string cbPh { get; set; }

        [StringLength(200)]
        public string cName { get; set; }

        [StringLength(200)]
        public string cbType { get; set; }

        public int? nWC { get; set; }

        public bool? cbStart { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? cbStartDate { get; set; }

        public bool? cbVoid { get; set; }

        public bool? cbView { get; set; }

        [StringLength(200)]
        public string cbDetails { get; set; }

        [StringLength(50)]
        public string cbCC { get; set; }

        public bool? cbTableType { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Customers Customers { get; set; }
    }
}
