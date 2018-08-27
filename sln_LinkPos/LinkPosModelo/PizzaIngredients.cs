namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PizzaIngredients
    {
        [Key]
        public int PizzaIngredientId { get; set; }

        [StringLength(50)]
        public string PizzaIngredientName { get; set; }

        [StringLength(50)]
        public string PrepText { get; set; }

        public bool? Disable { get; set; }

        public int? PriceLevelId { get; set; }

        public int? ButtonPosition { get; set; }

        public int? ButtonImageId { get; set; }

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

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
