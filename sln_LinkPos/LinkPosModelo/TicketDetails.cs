namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TicketDetails
    {
        public int TicketDetailsId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public int? TicketID { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public int? ItemTypeId { get; set; }

        public int? ItemId { get; set; }

        public double? Price { get; set; }

        public double? Tax { get; set; }

        public short? TaxRateId { get; set; }

        [StringLength(50)]
        public string BoundItem { get; set; }

        public bool? TakeOut { get; set; }

        public double? Quantity { get; set; }

        public double? TaxTotal { get; set; }

        public int? GuestId { get; set; }

        public int? MiscPrinterId { get; set; }

        public int? ItemStatusId { get; set; }

        public bool? Removed { get; set; }

        public int? RemovedItemReasonId { get; set; }

        public int? RefundId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? HoldDateTime { get; set; }

        public double? IniQty { get; set; }

        public double? Deposit { get; set; }

        [StringLength(100)]
        public string PrepPrinters { get; set; }

        [StringLength(100)]
        public string PrepText { get; set; }

        [StringLength(100)]
        public string PrepText2 { get; set; }

        public double? InventoryAdjust { get; set; }

        public bool? IsModifier { get; set; }

        [StringLength(5)]
        public string LabelPrinters { get; set; }

        public double? LineItemDiscountAmount { get; set; }

        public double? LineItemDiscountValue { get; set; }

        public int? LineItemDiscountType { get; set; }

        public double? OriginalPrice { get; set; }

        public double? InventoryAddedQty { get; set; }

        public int? RevenueCenterID { get; set; }

        [StringLength(50)]
        public string GuestName { get; set; }

        [StringLength(50)]
        public string ItemNotes { get; set; }

        public bool? IsSpecialPrice { get; set; }

        public int? UserID { get; set; }

        public int? CompUserID { get; set; }

        public int? LineDiscountUserID { get; set; }

        public int? VoidUserID { get; set; }

        public int? PriceChangeUserID { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Tickets Tickets { get; set; }
    }
}
