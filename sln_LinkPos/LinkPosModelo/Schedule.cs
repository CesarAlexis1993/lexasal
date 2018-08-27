namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Schedule")]
    public partial class Schedule
    {
        public int ScheduleId { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? SchDate { get; set; }

        public int? ShiftId { get; set; }

        public int? PermissionId { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        public double? HourlyPay { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
