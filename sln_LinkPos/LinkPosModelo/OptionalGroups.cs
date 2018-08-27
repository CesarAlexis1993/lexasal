namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OptionalGroups
    {
        [Key]
        public int OptionalGroupId { get; set; }

        [StringLength(50)]
        public string OptionalGroupDescription { get; set; }

        [StringLength(50)]
        public string Language2 { get; set; }

        public bool? Disable { get; set; }

        public bool? Exclusive { get; set; }

        public int? OptionalLevel1 { get; set; }

        public int? OptionalLevel2 { get; set; }

        public int? OptionalLevel3 { get; set; }

        public int? OptionalLevel4 { get; set; }

        public int? OptionalLevel5 { get; set; }

        public double? Markup { get; set; }

        public int? OptionalType { get; set; }

        public int? IngredientsIncluded { get; set; }

        [StringLength(10)]
        public string IngredientsPrefix { get; set; }

        public double? MaximumAllowed { get; set; }

        public double? PreventDuplicateModifierLevels { get; set; }

        [StringLength(50)]
        public string dnBackground { get; set; }

        [StringLength(50)]
        public string dnForeground { get; set; }

        public int? Rows { get; set; }

        public int? Columns { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
