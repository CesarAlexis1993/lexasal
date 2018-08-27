namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegularMenu")]
    public partial class RegularMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegularMenu()
        {
            MenuComboMap = new HashSet<MenuComboMap>();
        }

        [Key]
        public int RegularItemId { get; set; }

        [Required]
        [StringLength(255)]
        public string ItemName { get; set; }

        [StringLength(255)]
        public string ItemDescription { get; set; }

        [StringLength(50)]
        public string Language2 { get; set; }

        [StringLength(50)]
        public string PrepText { get; set; }

        [StringLength(50)]
        public string PrepTextLanguage2 { get; set; }

        public int? Visibility { get; set; }

        public int? ButtonPosition { get; set; }

        [StringLength(50)]
        public string SKU { get; set; }

        public int? MenuCategoryId { get; set; }

        public double? Price { get; set; }

        public double? BonusPrice { get; set; }

        public int? PLU { get; set; }

        public bool? PriceByWeight { get; set; }

        public double? PriceByWeightMultiplier { get; set; }

        [StringLength(50)]
        public string PriceByWeightSuffix { get; set; }

        public int TaxRateId { get; set; }

        public double? ContainerCharge { get; set; }

        public double? Deposit { get; set; }

        public int? OrderTypeId { get; set; }

        [StringLength(255)]
        public string WebDescription { get; set; }

        [StringLength(50)]
        public string AdditionalPrepTime { get; set; }

        public bool? FoodStampable { get; set; }

        public bool? VerifyAge { get; set; }

        public bool? BulkQty { get; set; }

        public double? BulkQtyAdditional { get; set; }

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

        public bool? RestrictDays { get; set; }

        public bool? Day1 { get; set; }

        public bool? Day2 { get; set; }

        public bool? Day3 { get; set; }

        public bool? Day4 { get; set; }

        public bool? Day5 { get; set; }

        public bool? Day6 { get; set; }

        public bool? Day7 { get; set; }

        public int? ButtonImageId { get; set; }

        public int? RecipeImageId { get; set; }

        public int? LoyaltyPointValue { get; set; }

        public int? LoyaltyPointRedemption { get; set; }

        public bool? ExcludeFromSpecialPricing { get; set; }

        public bool? ExcludeFromEventPricing { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOff { get; set; }

        public int? Availability { get; set; }

        public int? WebImageId { get; set; }

        [StringLength(50)]
        public string dnButtonBackground { get; set; }

        [StringLength(50)]
        public string dnButtonImagePathFill { get; set; }

        [StringLength(50)]
        public string dnButtonForeground { get; set; }

        public int? dnImageType { get; set; }

        public int? dnImagePathID { get; set; }

        public bool? RetailFavorite { get; set; }

        public bool? ExcludeFromDiscounts { get; set; }

        public int? ModifierGroupsVisibleRows { get; set; }

        [StringLength(32)]
        public string ERPID { get; set; }

        public int? RevenueCenterID { get; set; }

        public bool? ExcludeFromCombos { get; set; }

        public bool? SpecialsList { get; set; }

        public bool? NewItemsList { get; set; }

        [StringLength(10)]
        public string RibbonColor { get; set; }

        [StringLength(10)]
        public string RibbonText { get; set; }

        public double? WebPrice { get; set; }

        public string VectorImage { get; set; }

        public byte[] BitmapImage { get; set; }

        public byte[] WebImage { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual MenuCategories MenuCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuComboMap> MenuComboMap { get; set; }
    }
}
