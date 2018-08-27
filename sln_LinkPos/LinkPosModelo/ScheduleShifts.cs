namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ScheduleShifts
    {
        [Key]
        public int ShiftId { get; set; }

        [StringLength(200)]
        public string ShiftName { get; set; }

        public int? PermissionId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartShift { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndShift { get; set; }

        public double? TotalHours { get; set; }

        public int? LineColor { get; set; }

        [StringLength(50)]
        public string BackgroundColor { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
