namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocationSettingsBoolean")]
    public partial class LocationSettingsBoolean
    {
        [Key]
        public int SettingID { get; set; }

        [StringLength(200)]
        public string SettingKey { get; set; }

        public int? LocationSettingsTypeId { get; set; }

        public bool? SettingValue { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? HelpID { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual LocationSettingsTypes LocationSettingsTypes { get; set; }
    }
}
