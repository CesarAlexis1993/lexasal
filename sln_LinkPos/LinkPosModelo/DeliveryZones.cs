namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DeliveryZones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeliveryZones()
        {
            CustomerDetails = new HashSet<CustomerDetails>();
        }

        [Key]
        public int DeliveryZoneId { get; set; }

        public int? ButtonPosition { get; set; }

        [StringLength(50)]
        public string ZoneName { get; set; }

        [StringLength(50)]
        public string ZoneDescription { get; set; }

        public double? ZoneCharge { get; set; }

        public short? TaxRateId { get; set; }

        public bool? Disable { get; set; }

        public double? FreeLimit { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerDetails> CustomerDetails { get; set; }
    }
}
