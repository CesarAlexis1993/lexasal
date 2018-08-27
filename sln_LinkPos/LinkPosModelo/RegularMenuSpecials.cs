namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RegularMenuSpecials
    {
        [Key]
        public int SpecialPriceId { get; set; }

        public int? RegularItemId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndTime { get; set; }

        public int? DayOfWeek { get; set; }

        public int? PriceMethod { get; set; }

        public double? Price { get; set; }

        public bool? ApplyDiscountOptionals { get; set; }

        public bool? Disable { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
