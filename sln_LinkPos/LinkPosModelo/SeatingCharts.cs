namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SeatingCharts
    {
        public int SeatingChartsId { get; set; }

        [Required]
        [StringLength(20)]
        public string ButtonCaption { get; set; }

        public bool? Disable { get; set; }

        public int? BackgroundColor { get; set; }

        public int? ImageId { get; set; }

        public int? ImagePositionX { get; set; }

        public int? ImagePositionY { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOff { get; set; }

        public bool? ImageTile { get; set; }

        [StringLength(30)]
        public string BackgroundColorTop { get; set; }

        [StringLength(30)]
        public string BackgroundColorBottom { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
