namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomCharges
    {
        [Key]
        public int RoomChargeId { get; set; }

        public int? TicketId { get; set; }

        [StringLength(10)]
        public string RoomNum { get; set; }

        [StringLength(50)]
        public string Folio { get; set; }

        public int? FolioNumber { get; set; }

        public double? TxAmount { get; set; }

        public double? GratuityAmount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public string PMSSent { get; set; }

        public string PMSResponse { get; set; }

        public int? TerminalId { get; set; }

        public int? UserId { get; set; }

        public bool? Archived { get; set; }

        public bool? Void { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
