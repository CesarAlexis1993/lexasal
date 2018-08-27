namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipOfTheDay")]
    public partial class TipOfTheDay
    {
        public int TipOfTheDayId { get; set; }

        [Column("TipOfTheDay")]
        [StringLength(255)]
        public string TipOfTheDay1 { get; set; }

        public bool? LastVisible { get; set; }

        public int? ImageId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
