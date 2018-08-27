namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PayRates
    {
        [Key]
        public int PayRateId { get; set; }

        [StringLength(50)]
        public string PayRateDescription { get; set; }

        public double? NormalRate { get; set; }

        public double? OTRate { get; set; }

        public double? HolidayRate { get; set; }

        public int? OTStartHour { get; set; }

        public bool? bSalary { get; set; }

        public int? SalaryWeeklyHours { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
