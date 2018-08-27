namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ErrorsLog")]
    public partial class ErrorsLog
    {
        [Key]
        public int ErrorLogId { get; set; }

        public int? UserId { get; set; }

        public int? ErrorNumber { get; set; }

        [StringLength(255)]
        public string ErrorDescription { get; set; }

        [StringLength(255)]
        public string ErrorDetails { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
