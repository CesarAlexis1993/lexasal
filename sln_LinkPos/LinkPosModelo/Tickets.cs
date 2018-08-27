namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tickets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tickets()
        {
            CreditCardTransactions = new HashSet<CreditCardTransactions>();
            DiscountsLog = new HashSet<DiscountsLog>();
            PMSTransactions = new HashSet<PMSTransactions>();
            TicketDetails = new HashSet<TicketDetails>();
            Transactions = new HashSet<Transactions>();
        }

        [Key]
        public int TicketId { get; set; }

        public int? UserId { get; set; }

        public int? CustomerDetailsId { get; set; }

        public int? OrderTypeId { get; set; }

        public int? SeatingChartId { get; set; }

        public int? TerminalId { get; set; }

        public int? Guests { get; set; }

        public double? Subtotal { get; set; }

        public double? Tax1 { get; set; }

        public double? Tax2 { get; set; }

        public double? Tax3 { get; set; }

        public bool? TaxExempt { get; set; }

        public double? Discount { get; set; }

        public int? Split { get; set; }

        public bool? Combined { get; set; }

        public int? NewTicketId { get; set; }

        public double? GratuityAmount { get; set; }

        public bool? Bank { get; set; }

        public int? BarTabId { get; set; }

        public bool? Settled { get; set; }

        public bool? Void { get; set; }

        public int? VoidUserId { get; set; }

        public int? VoidReasonId { get; set; }

        public string Notes { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? DeliveryStatus { get; set; }

        public int? DrawerId { get; set; }

        public bool? DrawerReset { get; set; }

        public bool? Archived { get; set; }

        public bool? CheckIn { get; set; }

        public int? RefundId { get; set; }

        public double? BarTaxInc1 { get; set; }

        public double? BarTaxInc2 { get; set; }

        public double? BarTaxInc3 { get; set; }

        public int? SRMStatus { get; set; }

        [StringLength(50)]
        public string WebOrderId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DelayOrderDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? OrderStarted { get; set; }

        public bool? DelayOrder { get; set; }

        public double? DeliveryCharge { get; set; }

        public double? SurchargeAmount { get; set; }

        public int? GratuityTypeID { get; set; }

        public int? LoyaltyCardId { get; set; }

        public double? LoyaltyCardBonus { get; set; }

        public int? DrawerResetID { get; set; }

        [StringLength(100)]
        public string LoyaltyCardTrack { get; set; }

        public int? CompUserID { get; set; }

        public int? CombineUserID { get; set; }

        public int? OrderStatus { get; set; }

        public int? CallCenterTicketId { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditCardTransactions> CreditCardTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountsLog> DiscountsLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMSTransactions> PMSTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketDetails> TicketDetails { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
