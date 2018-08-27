namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TimeSheetBreaks
    {
        [Key]
        public int BreakId { get; set; }

        public int? TimeSheetId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BreakStart { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BreakEnd { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual TimeSheet TimeSheet { get; set; }
    }
}
