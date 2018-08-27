namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiftCardServerLog")]
    public partial class GiftCardServerLog
    {
        [Key]
        [Column(Order = 0)]
        public int GiftCardServerLogID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeDateStamp { get; set; }

        public int? OperatorID { get; set; }

        [StringLength(50)]
        public string TranCode { get; set; }

        [StringLength(50)]
        public string AcctNo { get; set; }

        [StringLength(50)]
        public string RefNo { get; set; }

        public int? InvNo { get; set; }

        [StringLength(50)]
        public string SequenceNo { get; set; }

        [StringLength(50)]
        public string AuthCode { get; set; }

        public double? Amount { get; set; }

        public double? Balance { get; set; }

        public bool? Void { get; set; }

        public bool? Archived { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
