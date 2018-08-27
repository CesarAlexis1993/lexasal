namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerDetails
    {
        public int CustomerDetailsId { get; set; }

        public int? CustomerID { get; set; }

        [StringLength(50)]
        public string LocationName { get; set; }

        public int? PhoneAreaCode { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public int? PhoneExtension { get; set; }

        [StringLength(50)]
        public string NumberStreet { get; set; }

        [StringLength(50)]
        public string AddressStreet { get; set; }

        [StringLength(50)]
        public string AddressStreet2 { get; set; }

        [StringLength(50)]
        public string AddressCity { get; set; }

        [StringLength(50)]
        public string AddressRegion { get; set; }

        [StringLength(50)]
        public string AddressPostalCode { get; set; }

        [StringLength(255)]
        public string AdditionalNotes { get; set; }

        public int? DeliveryZoneId { get; set; }

        public bool? NonTaxable { get; set; }

        public int? TransactionTypeId { get; set; }

        public bool? DefaultLocation { get; set; }

        [StringLength(20)]
        public string Distance { get; set; }

        [StringLength(25)]
        public string Duration { get; set; }

        [StringLength(35)]
        public string Geocode { get; set; }

        public int? PhoneNumberType { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Customers Customers { get; set; }

        public virtual DeliveryZones DeliveryZones { get; set; }
    }
}
