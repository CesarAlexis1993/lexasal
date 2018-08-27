namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OptionalLevels
    {
        [Key]
        public int OptionalLevelId { get; set; }

        [StringLength(50)]
        public string ButtonCaption { get; set; }

        public int? Visibility { get; set; }

        [StringLength(50)]
        public string Language2 { get; set; }

        [StringLength(50)]
        public string PrepText { get; set; }

        [StringLength(50)]
        public string PrepTextLangauge2 { get; set; }

        public int? ButtonImageId { get; set; }

        public int? RecipeImageId { get; set; }

        public double? QuantityMultiplier { get; set; }

        [StringLength(50)]
        public string dnButtonBackground { get; set; }

        [StringLength(50)]
        public string dnButtonImagePathFill { get; set; }

        [StringLength(50)]
        public string dnButtonForeground { get; set; }

        public int? dnImageType { get; set; }

        public int? dnImagePathID { get; set; }

        public string VectorImage { get; set; }

        public byte[] BitmapImage { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
