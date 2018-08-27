namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class uiTransactionButtons
    {
        [Key]
        public int ButtonId { get; set; }

        public int? ButtonPosition { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string ButtonCaption { get; set; }

        public bool? Disable { get; set; }

        public int? ButtonImageId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
