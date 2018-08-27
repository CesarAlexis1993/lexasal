namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Combos
    {
        [Key]
        public int ComboID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public bool? Disable { get; set; }

        public double? Price { get; set; }

        public double? Upsize { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Expires { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeOn { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeOff { get; set; }

        public int? Category1 { get; set; }

        public int? Category2 { get; set; }

        public int? Category3 { get; set; }

        public int? Category4 { get; set; }

        public int? Category5 { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
