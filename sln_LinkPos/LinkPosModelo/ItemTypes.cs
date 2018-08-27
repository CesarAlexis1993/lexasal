namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemTypeId { get; set; }

        [StringLength(50)]
        public string ItemTypeDescription { get; set; }

        public int? ItemTypeParentCategoryId { get; set; }

        public bool? IsOptional { get; set; }

        [StringLength(50)]
        public string ReportCaption { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
