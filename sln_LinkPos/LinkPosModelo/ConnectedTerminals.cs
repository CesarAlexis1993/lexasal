namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConnectedTerminals
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TIME_ON { get; set; }

        [StringLength(50)]
        public string P_KEY { get; set; }

        [StringLength(50)]
        public string TX_HASH { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
