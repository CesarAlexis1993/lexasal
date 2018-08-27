namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PizzaStyles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PizzaStyles()
        {
            PizzaMenuShortcuts = new HashSet<PizzaMenuShortcuts>();
        }

        [Key]
        public int PizzaStyleId { get; set; }

        [StringLength(50)]
        public string PizzaStyleName { get; set; }

        [StringLength(50)]
        public string PrepText { get; set; }

        public int? StylePriceGroupId { get; set; }

        public int? ButtonPosition { get; set; }

        public bool? Disable { get; set; }

        public int? IngredientsIncluded { get; set; }

        public bool? EnablePriceLevel1 { get; set; }

        public bool? EnablePriceLevel2 { get; set; }

        public bool? EnablePriceLevel3 { get; set; }

        public bool? EnablePriceLevel4 { get; set; }

        public bool? EnablePriceLevel5 { get; set; }

        public int? ButtonImageId { get; set; }

        public int? RecipeImageId { get; set; }

        public int? ButtonColor { get; set; }

        public int? FontColor { get; set; }

        public bool? ShowCaption { get; set; }

        public int? TextAlign { get; set; }

        public int? TextPosition { get; set; }

        public int? ImageAlign { get; set; }

        public int? FontSize { get; set; }

        public bool? FontBold { get; set; }

        public bool? FontItalic { get; set; }

        [StringLength(100)]
        public string PrepTextLanguage2 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PizzaMenuShortcuts> PizzaMenuShortcuts { get; set; }

        public virtual PizzaStylesPricing PizzaStylesPricing { get; set; }
    }
}
