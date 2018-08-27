namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CallerIdEntries
    {
        [Key]
        public int LogId { get; set; }

        [StringLength(50)]
        public string CallerIdLine { get; set; }

        [StringLength(50)]
        public string CallerIdIO { get; set; }

        [StringLength(50)]
        public string CallerIdType { get; set; }

        [StringLength(255)]
        public string CallerIdString { get; set; }

        [StringLength(50)]
        public string CallerIdPhone { get; set; }

        [StringLength(50)]
        public string CallerIdName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
