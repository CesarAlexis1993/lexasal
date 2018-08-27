namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdValorem")]
    public partial class AdValorem
    {
        public int? MenuCategoryID { get; set; }

        [StringLength(50)]
        public string MenuCategoryText { get; set; }

        public double? IMPUESTOADVALOR { get; set; }

        [StringLength(50)]
        public string CATEGORIAMH { get; set; }

        [Key]
        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
