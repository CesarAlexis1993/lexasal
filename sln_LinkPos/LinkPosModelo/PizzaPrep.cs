namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PizzaPrep")]
    public partial class PizzaPrep
    {
        public int PizzaPrepId { get; set; }

        public int? ButtonPosition { get; set; }

        [StringLength(50)]
        public string ButtonCaption { get; set; }

        [StringLength(50)]
        public string PrepText { get; set; }

        public bool? Disable { get; set; }

        public double? Price { get; set; }

        public int? ButtonImageId { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
