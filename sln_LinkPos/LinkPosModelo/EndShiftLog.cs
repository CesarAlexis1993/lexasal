namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EndShiftLog")]
    public partial class EndShiftLog
    {
        [Key]
        [Column(Order = 0)]
        public int EndShiftLogID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeDateStamp { get; set; }

        public int? ManagerID { get; set; }

        public int? UserID { get; set; }

        public bool? IsDriver { get; set; }

        public string TextReport { get; set; }

        public bool? Archived { get; set; }

        public int? TerminalID { get; set; }

        public int? CashDrawerID { get; set; }

        public double? DepositsOffset { get; set; }

        public bool? DrawerReset { get; set; }

        public int? DrawerResetID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
