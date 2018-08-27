namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermissionMapping")]
    public partial class PermissionMapping
    {
        [Key]
        public int PermissionMapId { get; set; }

        public int? UserID { get; set; }

        public int? PermissionId { get; set; }

        public bool? DefaultPermission { get; set; }

        public double? BasePay { get; set; }

        public int? PayType { get; set; }

        public double? Salary { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Users Users { get; set; }

        public virtual Permissions Permissions { get; set; }
    }
}
