namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            CustomerBookings = new HashSet<CustomerBookings>();
            CustomerDetails = new HashSet<CustomerDetails>();
        }

        [Key]
        public int CustomerId { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        public bool? SendOffers { get; set; }

        public bool? TaxExempt { get; set; }

        [StringLength(50)]
        public string DriverLicenseId { get; set; }

        public int? TroutD { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CustomerSince { get; set; }

        public int? LoyaltyCardId { get; set; }

        [StringLength(50)]
        public string UserDefinedField1 { get; set; }

        [StringLength(50)]
        public string UserDefinedField2 { get; set; }

        [StringLength(50)]
        public string UserDefinedField3 { get; set; }

        public int? CustomerImageID { get; set; }

        public int? SignatureImageID { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string LoyaltyCardTrack { get; set; }

        public bool? IsBlocked { get; set; }

        [StringLength(50)]
        public string ReasonBlocked { get; set; }

        public byte[] CustomerImage { get; set; }

        public byte[] SignatureImage { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerBookings> CustomerBookings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerDetails> CustomerDetails { get; set; }
    }
}
