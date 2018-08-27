namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebOrderReadyTime")]
    public partial class WebOrderReadyTime
    {
        public int WebOrderReadyTimeId { get; set; }

        [StringLength(50)]
        public string WebOrderReadyTimeDesc { get; set; }

        public int? MinutesOffset { get; set; }

        public int? ButtonPosition { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
