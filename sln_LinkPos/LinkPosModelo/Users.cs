namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            DrawerResetLog = new HashSet<DrawerResetLog>();
            PermissionMapping = new HashSet<PermissionMapping>();
            Tickets = new HashSet<Tickets>();
            TimeSheet = new HashSet<TimeSheet>();
            Transactions = new HashSet<Transactions>();
            UserActionsLog = new HashSet<UserActionsLog>();
            UserFingerprints = new HashSet<UserFingerprints>();
        }

        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int LoginId { get; set; }

        public bool? Disable { get; set; }

        public bool? TimeClockMandatory { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BirthDate { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string LoginPassword { get; set; }

        [StringLength(50)]
        public string NationalIdNumber { get; set; }

        public string StreetAddress { get; set; }

        [StringLength(50)]
        public string AddressLine2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateHired { get; set; }

        public bool? Released { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateReleased { get; set; }

        [StringLength(50)]
        public string ReasonReleased { get; set; }

        [StringLength(20)]
        public string DriverLicenseId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DriverLicenseExpires { get; set; }

        [StringLength(30)]
        public string AutoInsuranceCompany { get; set; }

        [StringLength(20)]
        public string AutoInsuranceId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AutoInsuranceExpires { get; set; }

        public int? LanguageId { get; set; }

        public bool? ScheduleMandatory { get; set; }

        [StringLength(254)]
        public string Notes { get; set; }

        [StringLength(50)]
        public string CardTrackData { get; set; }

        public int? PayRateId { get; set; }

        public int? ImageId { get; set; }

        [StringLength(15)]
        public string AlternatePhone { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        [StringLength(15)]
        public string Country { get; set; }

        [StringLength(15)]
        public string FaxNumber { get; set; }

        [StringLength(15)]
        public string MobilePhone { get; set; }

        [StringLength(15)]
        public string PagerNumber { get; set; }

        [StringLength(15)]
        public string PagerPin { get; set; }

        public int? Gender { get; set; }

        [StringLength(15)]
        public string Salutation { get; set; }

        [StringLength(15)]
        public string Suffix { get; set; }

        [StringLength(75)]
        public string iButtonSN { get; set; }

        public int? PCChargeCashierId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrawerResetLog> DrawerResetLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionMapping> PermissionMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeSheet> TimeSheet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transactions> Transactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserActionsLog> UserActionsLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFingerprints> UserFingerprints { get; set; }
    }
}
