namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiftCards
    {
        [Key]
        public int GiftCardID { get; set; }

        [StringLength(200)]
        public string GiftCardStripe { get; set; }

        public int? UserID { get; set; }

        public bool? Disable { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Expires { get; set; }

        public int? VoidBy { get; set; }

        public int? PinNumber { get; set; }

        [StringLength(200)]
        public string VoidReason { get; set; }

        public int? GiftCardTypeId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
