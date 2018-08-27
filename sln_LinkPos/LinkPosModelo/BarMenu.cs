namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BarMenu")]
    public partial class BarMenu
    {
        [Key]
        public int BarItemId { get; set; }

        [StringLength(50)]
        public string BarMenuItem { get; set; }

        [StringLength(50)]
        public string Language2 { get; set; }

        [StringLength(50)]
        public string PrepText { get; set; }

        [StringLength(50)]
        public string PrepTextLanguage2 { get; set; }

        public int? Visibility { get; set; }

        public int? ButtonPosition { get; set; }

        public double? Price { get; set; }

        public double? Upcharge1 { get; set; }

        public double? Upcharge2 { get; set; }

        public double? Upcharge3 { get; set; }

        public double? Upcharge4 { get; set; }

        public double? Upcharge5 { get; set; }

        public double? Upcharge6 { get; set; }

        public bool? AddToShortcuts { get; set; }

        public bool? Prep1 { get; set; }

        public bool? Prep2 { get; set; }

        public bool? Prep3 { get; set; }

        public bool? Prep4 { get; set; }

        public bool? Prep5 { get; set; }

        public bool? Prep6 { get; set; }

        public bool? Prep7 { get; set; }

        public bool? Prep8 { get; set; }

        public bool? Prep9 { get; set; }

        public bool? Prep10 { get; set; }

        public bool? Label1 { get; set; }

        public bool? Label2 { get; set; }

        public bool? Label3 { get; set; }

        public bool? Label4 { get; set; }

        public bool? Label5 { get; set; }

        public int? ButtonImageId { get; set; }

        public int? RecipeImageId { get; set; }

        public int? BarRecipeId { get; set; }

        public int? LoyaltyPointValue { get; set; }

        public int? LoyaltyPointRedemption { get; set; }

        [StringLength(50)]
        public string SKU { get; set; }

        public double? Deposit { get; set; }

        public int? MenuCategoryId { get; set; }

        public bool? ExcludeFromSpecialPricing { get; set; }

        public bool? ExcludeFromEventPricing { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOff { get; set; }

        public int? Availability { get; set; }

        [StringLength(255)]
        public string WebDescription { get; set; }

        public int? WebImageId { get; set; }

        [StringLength(50)]
        public string dnButtonBackground { get; set; }

        [StringLength(50)]
        public string dnButtonImagePathFill { get; set; }

        [StringLength(50)]
        public string dnButtonForeground { get; set; }

        public int? dnImageType { get; set; }

        public int? dnImagePathID { get; set; }

        public bool? ExcludeFromDiscounts { get; set; }

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
