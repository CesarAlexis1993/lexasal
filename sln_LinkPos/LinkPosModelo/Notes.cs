namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notes
    {
        [Key]
        public int NoteId { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeDateStamp { get; set; }

        public bool? Hide { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
