namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PizzaSizes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PizzaSizes()
        {
            PizzaMenuShortcuts = new HashSet<PizzaMenuShortcuts>();
        }

        [Key]
        public int PizzaSizeId { get; set; }

        [StringLength(50)]
        public string PizzaSizeName { get; set; }

        public int? Visibility { get; set; }

        [StringLength(50)]
        public string PrepText { get; set; }

        public int? ButtonPosition { get; set; }

        public int? StylePriceLevelId { get; set; }

        public int? IngredientPriceGroupId { get; set; }

        public int? TaxRateId { get; set; }

        public bool? ShowImage { get; set; }

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

        public int? LoyaltyPointValue { get; set; }

        public int? LoyaltyPointRedemption { get; set; }

        public int? ButtonColor { get; set; }

        public int? FontColor { get; set; }

        public bool? ShowCaption { get; set; }

        public int? TextAlign { get; set; }

        public int? TextPosition { get; set; }

        public int? ImageAlign { get; set; }

        public int? FontSize { get; set; }

        public bool? FontBold { get; set; }

        public bool? FontItalic { get; set; }

        public int? RecipeImageId { get; set; }

        [StringLength(100)]
        public string PrepTextLanguage2 { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOff { get; set; }

        public double? InventoryMultiplier { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual PizzaIngredientsPricing PizzaIngredientsPricing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PizzaMenuShortcuts> PizzaMenuShortcuts { get; set; }
    }
}
