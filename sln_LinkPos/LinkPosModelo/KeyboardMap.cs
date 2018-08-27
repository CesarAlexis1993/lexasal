namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KeyboardMap")]
    public partial class KeyboardMap
    {
        public int KeyboardMapId { get; set; }

        [StringLength(1)]
        public string EnglishText { get; set; }

        [StringLength(5)]
        public string DisplayText { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
