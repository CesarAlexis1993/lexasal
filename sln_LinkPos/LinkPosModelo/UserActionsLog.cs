namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserActionsLog")]
    public partial class UserActionsLog
    {
        public int UserActionsLogId { get; set; }

        public int? UserActionId { get; set; }

        public int? UserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? TicketId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual UserActions UserActions { get; set; }

        public virtual Users Users { get; set; }
    }
}
