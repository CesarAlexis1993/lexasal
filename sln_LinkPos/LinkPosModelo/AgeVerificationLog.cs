namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgeVerificationLog")]
    public partial class AgeVerificationLog
    {
        [Key]
        [Column(Order = 0)]
        public int AgeVerificationLogID { get; set; }

        public int? AgeVerificationMethodID { get; set; }

        public int? TicketID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Birthdate { get; set; }

        [StringLength(25)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
