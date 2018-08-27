namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmployeeActions
    {
        [Key]
        public int EmployeeActionId { get; set; }

        [StringLength(50)]
        public string ActionDescription { get; set; }

        public int? ActionId { get; set; }

        public bool? AuditAlert { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
