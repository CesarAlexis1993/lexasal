namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Optionals
    {
        [Key]
        public int OptionalId { get; set; }

        public int? OptionalGroupId { get; set; }

        [Required]
        [StringLength(50)]
        public string OptionalName { get; set; }

        [StringLength(50)]
        public string Language2 { get; set; }

        [StringLength(50)]
        public string PrepText { get; set; }

        [StringLength(50)]
        public string PrepTextLanguage2 { get; set; }

        public int? Visibility { get; set; }

        public int? OptionalType { get; set; }

        public int? ButtonPosition { get; set; }

        public bool? StoreOnly { get; set; }

        public bool? WebOnly { get; set; }

        public double? Price { get; set; }

        public double? PriceLevel1 { get; set; }

        public double? PriceLevel2 { get; set; }

        public double? PriceLevel3 { get; set; }

        public double? PriceLevel4 { get; set; }

        public double? PriceLevel5 { get; set; }

        public int? ButtonImageId { get; set; }

        public int? RecipeImageId { get; set; }

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
