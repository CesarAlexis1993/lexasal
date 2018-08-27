namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PizzaSalesReport")]
    public partial class PizzaSalesReport
    {
        [Key]
        public int PizzaSalesId { get; set; }

        public int? PizzaSizeId { get; set; }

        public int? PizzaStyleId { get; set; }

        public double? StyleQty { get; set; }

        public int? SizeQty { get; set; }

        public double? SizeTotalSales { get; set; }

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
