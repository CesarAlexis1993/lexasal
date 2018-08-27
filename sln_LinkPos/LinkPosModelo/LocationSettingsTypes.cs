namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LocationSettingsTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocationSettingsTypes()
        {
            LocationSettingsBoolean = new HashSet<LocationSettingsBoolean>();
            LocationSettingsNumeric = new HashSet<LocationSettingsNumeric>();
            LocationSettingsStrings = new HashSet<LocationSettingsStrings>();
            LocationSettingsTime = new HashSet<LocationSettingsTime>();
        }

        [Key]
        public int LocationSettingsTypeId { get; set; }

        [StringLength(50)]
        public string SettingTypeDesc { get; set; }

        public int? ParentCategoryId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationSettingsBoolean> LocationSettingsBoolean { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationSettingsNumeric> LocationSettingsNumeric { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationSettingsStrings> LocationSettingsStrings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationSettingsTime> LocationSettingsTime { get; set; }
    }
}
