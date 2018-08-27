namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemOptionals
    {
        [Key]
        public int ItemOptionalId { get; set; }

        public int? ButtonPosition { get; set; }

        [StringLength(50)]
        public string ButtonText { get; set; }

        [StringLength(50)]
        public string PrepText { get; set; }

        public int? ButtonImageID { get; set; }

        public bool? Disable { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
