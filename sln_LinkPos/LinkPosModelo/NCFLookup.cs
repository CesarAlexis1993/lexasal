namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NCFLookup")]
    public partial class NCFLookup
    {
        public int NCFLookupId { get; set; }

        [StringLength(50)]
        public string NCF { get; set; }

        public int? TicketId { get; set; }

        public int? NCFType { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
