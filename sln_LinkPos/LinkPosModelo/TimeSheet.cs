namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimeSheet")]
    public partial class TimeSheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimeSheet()
        {
            TimeSheetBreaks = new HashSet<TimeSheetBreaks>();
        }

        public int TimeSheetID { get; set; }

        public int UserId { get; set; }

        public int? PermissionID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ShiftStart { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ShiftEnd { get; set; }

        public int? CashDrawerId { get; set; }

        public double? GratuitiesCash { get; set; }

        public double? GratuitiesNonCash { get; set; }

        public bool? UseBank { get; set; }

        public double? StartBank { get; set; }

        public double? EndBank { get; set; }

        public bool? HouseBank { get; set; }

        public int? PayType { get; set; }

        public double? HourlyPay { get; set; }

        public double? OTHours1 { get; set; }

        public double? OTHours2 { get; set; }

        public double? LaborCost { get; set; }

        public bool? IsClockedOut { get; set; }

        public double? TipableSales { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Permissions Permissions { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeSheetBreaks> TimeSheetBreaks { get; set; }
    }
}
