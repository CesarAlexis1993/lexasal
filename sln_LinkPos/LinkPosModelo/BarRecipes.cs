namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BarRecipes
    {
        [Key]
        public int BarRecipeId { get; set; }

        [StringLength(50)]
        public string BarRecipeName { get; set; }

        public string BarRecipeIngredients { get; set; }

        public string BarRecipeDesc { get; set; }

        public int? ImageId { get; set; }

        public int? BarRecipeCategoryID { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
