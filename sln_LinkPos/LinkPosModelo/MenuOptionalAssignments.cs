namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MenuOptionalAssignments
    {
        [Key]
        public int MenuOptionalMapId { get; set; }

        public int? RegularItemId { get; set; }

        public int? OptionalGroupId { get; set; }

        public int? SortOrder { get; set; }

        public bool? Mandatory { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
