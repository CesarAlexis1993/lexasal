namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EndOfDayReports
    {
        [Key]
        public int MiniReportId { get; set; }

        public int? ReportId { get; set; }

        [StringLength(50)]
        public string ReportName { get; set; }

        public int? ButtonPosition { get; set; }

        public int? ButtonImageId { get; set; }

        public bool? AutoPrintEndOfDay { get; set; }

        public bool? Disable { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
