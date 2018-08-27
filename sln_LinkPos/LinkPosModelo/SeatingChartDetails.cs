namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SeatingChartDetails
    {
        [Key]
        public int SeatingChartId { get; set; }

        [StringLength(50)]
        public string TableCaption { get; set; }

        public bool? ShowCaption { get; set; }

        public int RoomID { get; set; }

        public bool? ImageOnly { get; set; }

        public int? MaximumGuests { get; set; }

        public bool? Smoking { get; set; }

        public bool? Window { get; set; }

        public bool? Booth { get; set; }

        public bool? Private { get; set; }

        public int? ImageId { get; set; }

        public int? PositionX { get; set; }

        public int? PositionY { get; set; }

        public int? FontColor { get; set; }

        public int? FontSize { get; set; }

        public bool? FontBold { get; set; }

        public bool? FontItalic { get; set; }

        public int? AvgTurn { get; set; }

        public int? ImageW { get; set; }

        public int? ImageH { get; set; }

        [StringLength(30)]
        public string StyleKey { get; set; }

        [StringLength(30)]
        public string FillColor { get; set; }

        [StringLength(30)]
        public string LineColor { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
