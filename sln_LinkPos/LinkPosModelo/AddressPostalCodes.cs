namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AddressPostalCodes
    {
        [Key]
        public int AddressPostalCodeId { get; set; }

        [StringLength(50)]
        public string AddressPostalCode { get; set; }

        [StringLength(50)]
        public string DeliveryZoneId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
