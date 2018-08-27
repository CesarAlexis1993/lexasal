namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BarOptionals
    {
        [Key]
        public int BarOptionalId { get; set; }

        [StringLength(50)]
        public string BarOptionalName { get; set; }

        [StringLength(50)]
        public string PrepText { get; set; }

        public int? ButtonPosition { get; set; }

        public int? Visibility { get; set; }

        public double? Price { get; set; }

        public bool? AllCategories { get; set; }

        public int? Category1 { get; set; }

        public int? Category2 { get; set; }

        public int? Category3 { get; set; }

        public int? Category4 { get; set; }

        public int? Category5 { get; set; }

        public int? ButtonImageId { get; set; }

        [StringLength(64)]
        public string Language2 { get; set; }

        [StringLength(64)]
        public string PrepTextLanguage2 { get; set; }

        [StringLength(50)]
        public string dnButtonBackground { get; set; }

        [StringLength(50)]
        public string dnButtonImagePathFill { get; set; }

        [StringLength(50)]
        public string dnButtonForeground { get; set; }

        public int? dnImageType { get; set; }

        public int? dnImagePathID { get; set; }

        [StringLength(32)]
        public string ERPID { get; set; }

        public int? RevenueCenterID { get; set; }

        public string VectorImage { get; set; }

        public byte[] BitmapImage { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
