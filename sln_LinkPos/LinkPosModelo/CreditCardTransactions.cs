namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CreditCardTransactions
    {
        [Key]
        public int TransactionId { get; set; }

        public int? TicketId { get; set; }

        public int? TroutD { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? TransactionTypeId { get; set; }

        [StringLength(200)]
        public string TxResult { get; set; }

        [StringLength(200)]
        public string TxAuthNo { get; set; }

        [StringLength(200)]
        public string TxReference { get; set; }

        public int? TxSeqNo { get; set; }

        public bool? Swiped { get; set; }

        [StringLength(200)]
        public string CardIssuer { get; set; }

        [StringLength(200)]
        public string CardMember { get; set; }

        public double? TxAmount { get; set; }

        public double? Gratuity { get; set; }

        public int? Card4 { get; set; }

        public int? FollowOn { get; set; }

        public int? BarTabId { get; set; }

        public bool? Void { get; set; }

        public bool? Archived { get; set; }

        [StringLength(100)]
        public string MPAcqRefData { get; set; }

        [StringLength(100)]
        public string MPRecordNo { get; set; }

        public int? UserId { get; set; }

        public bool? Captured { get; set; }

        [StringLength(250)]
        public string EncStr1 { get; set; }

        [StringLength(250)]
        public string EncStr2 { get; set; }

        public bool? TxLogId { get; set; }

        public bool? CommercialCard { get; set; }

        [StringLength(5)]
        public string CommercialCardType { get; set; }

        [StringLength(25)]
        public string CustomerCode { get; set; }

        public string XMLRequest { get; set; }

        public string XMLResponse { get; set; }

        public int? PosStationID { get; set; }

        public int? CTroutD { get; set; }

        public double? CashBack { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Tickets Tickets { get; set; }
    }
}
