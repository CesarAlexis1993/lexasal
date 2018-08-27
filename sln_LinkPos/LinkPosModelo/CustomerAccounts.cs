namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerAccounts
    {
        [Key]
        public int CustomerAccountId { get; set; }

        public int? CustomerID { get; set; }

        public bool? Disable { get; set; }

        [StringLength(50)]
        public string DisableReason { get; set; }

        public double? MaximumValue { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateExpires { get; set; }

        public bool? RequireSwipe { get; set; }

        public int? CardSwipe { get; set; }

        public int? CardBarcode { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string CardNumber { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
