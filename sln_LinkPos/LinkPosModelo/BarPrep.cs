namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BarPrep")]
    public partial class BarPrep
    {
        public int BarPrepId { get; set; }

        [StringLength(200)]
        public string BarPrepName { get; set; }

        public int? ButtonPosition { get; set; }

        [StringLength(200)]
        public string Language2 { get; set; }

        [StringLength(200)]
        public string PrepText { get; set; }

        [StringLength(200)]
        public string PrepTextLanguage2 { get; set; }

        public int? Visibility { get; set; }

        public int? ButtonImageId { get; set; }

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
