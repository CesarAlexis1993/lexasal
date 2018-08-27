namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RemoteMessages
    {
        [Key]
        public int RemoteMessageId { get; set; }

        [StringLength(255)]
        public string MessageText { get; set; }

        public int? UserId { get; set; }

        public int? TerminalId { get; set; }

        public int? PrinterId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
