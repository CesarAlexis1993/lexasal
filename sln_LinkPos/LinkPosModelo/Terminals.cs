namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Terminals
    {
        public int ID { get; set; }

        public int? TerminalID { get; set; }

        [StringLength(50)]
        public string MachineID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastTimeOn { get; set; }

        [StringLength(50)]
        public string ActivationCode { get; set; }

        [StringLength(50)]
        public string WIndowsVersionId { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        [StringLength(50)]
        public string HardDriveId { get; set; }

        [StringLength(50)]
        public string LocationId { get; set; }

        public int? Usage { get; set; }

        public bool? isBackOfficeOnly { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
