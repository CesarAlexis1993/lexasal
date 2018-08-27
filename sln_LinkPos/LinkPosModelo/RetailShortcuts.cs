namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RetailShortcuts
    {
        [Key]
        public int PopularItemId { get; set; }

        public int? ButtonGroup { get; set; }

        public int? ButtonPosition { get; set; }

        public int? RegularItemId { get; set; }

        public int? ButtonColor { get; set; }

        public bool? Disable { get; set; }

        public int? ButtonImageId { get; set; }

        public bool? ShowCaption { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
