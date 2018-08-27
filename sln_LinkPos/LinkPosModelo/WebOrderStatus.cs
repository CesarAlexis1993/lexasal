namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebOrderStatus
    {
        public int WebOrderStatusId { get; set; }

        [StringLength(50)]
        public string WebOrderStatusDesc { get; set; }

        public bool? SendEmail { get; set; }

        public bool? SendSMS { get; set; }

        public bool? CheckIn { get; set; }

        public int? ButtonPosition { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
