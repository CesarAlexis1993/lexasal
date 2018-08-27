namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaidOutVendors
    {
        [Key]
        public int PaidOutVendorId { get; set; }

        public int? ButtonPosition { get; set; }

        [StringLength(50)]
        public string PaidOutVendor { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
