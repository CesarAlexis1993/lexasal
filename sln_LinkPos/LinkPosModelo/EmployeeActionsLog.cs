namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeActionsLog")]
    public partial class EmployeeActionsLog
    {
        public int EmployeeActionsLogId { get; set; }

        public int? UserId { get; set; }

        public int? ActionId { get; set; }

        public int? TicketId { get; set; }

        public int? PosStationId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
