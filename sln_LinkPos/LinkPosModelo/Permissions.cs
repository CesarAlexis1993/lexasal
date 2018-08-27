namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permissions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permissions()
        {
            PermissionMapping = new HashSet<PermissionMapping>();
            TimeSheet = new HashSet<TimeSheet>();
        }

        [Key]
        public int PermissionId { get; set; }

        [Required]
        [StringLength(30)]
        public string Permission { get; set; }

        public bool Disable { get; set; }

        public int? DefaultOrderTypeId { get; set; }

        public int? DefaultMenuCategoryId { get; set; }

        public int? DefaultBarCategoryId { get; set; }

        public bool? AllowSettle { get; set; }

        public bool? AllowCashSale { get; set; }

        public bool? AllowCreditCardSale { get; set; }

        public bool? AllowTransactionVoid { get; set; }

        public bool? AllowNoSale { get; set; }

        public bool? AllowManager { get; set; }

        public bool? AllowTimeClock { get; set; }

        public bool? AllowMessages { get; set; }

        public bool? AllowRemoveItems { get; set; }

        public bool? AllowPriceChange { get; set; }

        public bool? AllowVoidSlip { get; set; }

        public bool? AllowBackOffice { get; set; }

        public bool? AllowRefire { get; set; }

        public bool? AllowReprint { get; set; }

        public bool? AllowGiftCards { get; set; }

        public bool? AllowDiscounts { get; set; }

        public bool? AllowManualDiscounts { get; set; }

        public bool? AllowHold { get; set; }

        public bool? AllowCrossEdit { get; set; }

        public bool? AllowSplit { get; set; }

        public bool? AllowCombine { get; set; }

        public bool? AllowHouseAccounts { get; set; }

        public bool? AllowMiscItems { get; set; }

        public bool? AllowOverride { get; set; }

        public bool? AllowComp { get; set; }

        public bool? AllowRefund { get; set; }

        public bool DeclareGratuities { get; set; }

        public int PayMethod { get; set; }

        public double DefaultPayRate { get; set; }

        public bool? ManageFingerprints { get; set; }

        public bool? AllowPayouts { get; set; }

        public bool? TimeClockOnly { get; set; }

        public bool? AllowSQLQuery { get; set; }

        public bool? AllowCashDrawerOpen { get; set; }

        public bool? AllowSuspend { get; set; }

        public bool? AllowOrderEntry { get; set; }

        public bool? AllowTicketTransfer { get; set; }

        public bool? AllowBackOfficeSummary { get; set; }

        public bool? AllowBackOfficeReports { get; set; }

        public bool? AllowBackOfficeMenus { get; set; }

        public bool? AllowBackOfficeEmployees { get; set; }

        public bool? AllowBackOfficeCustomers { get; set; }

        public bool? AllowBackOfficeInventory { get; set; }

        public bool? AllowBackOfficeConfig { get; set; }

        public bool? ShowBackOfficeStatusBar { get; set; }

        public bool? AllowBarTabCrossEdit { get; set; }

        public bool? AllowPrepReprint { get; set; }

        public bool? AllowRoomCharge { get; set; }

        public bool? ShowBackOfficeStartScreen { get; set; }

        public bool? OrderEntryScreenCashButton { get; set; }

        public bool? AllowBarTabOverride { get; set; }

        public bool? OrderEntryScreenGratuityButton { get; set; }

        public bool? ManagerResetDrawer { get; set; }

        public bool? ManagerEndOfDay { get; set; }

        public bool? ManagerReports { get; set; }

        public bool? ManagerOrders { get; set; }

        public bool? ManagerCashDrops { get; set; }

        public bool? ManagerBanking { get; set; }

        public bool? ManagerSystem { get; set; }

        public bool? ManagerShutDown { get; set; }

        public bool? SeatingChartDesigner { get; set; }

        public bool? DisplaySettledOrders { get; set; }

        public bool? DisplayArchivedOrders { get; set; }

        public bool? AllowInventorySettings { get; set; }

        public bool? AllowInventoryReceive { get; set; }

        public bool? AllowInventoryCount { get; set; }

        public bool? AllowCreditCardAdjust { get; set; }

        public bool? AllowCreditCardOtherUsers { get; set; }

        public bool? AllowCreditCardTip { get; set; }

        public bool? AllowCreditCardTipAdjust { get; set; }

        public bool? AllowCreditCardVoid { get; set; }

        public bool? AllowCreditCardRefund { get; set; }

        public bool? AllowCreditCardBatch { get; set; }

        public bool? AllowCreditCardSettings { get; set; }

        public bool? AllowGiftCardActivate { get; set; }

        public bool? AllowGiftCardAddValue { get; set; }

        public bool? AllowGiftCardCashOut { get; set; }

        public bool? AllowGiftCardDeactivate { get; set; }

        public bool? AllowLineItemDiscount { get; set; }

        public bool? AllowWeightChange { get; set; }

        public bool? AllowBackOfficeDelete { get; set; }

        public bool? AllowBackOfficeVoid { get; set; }

        public bool? AllowBackOfficeCloud { get; set; }

        public bool? AllowQuantityAdjust { get; set; }

        public bool? DisplayOnTransferList { get; set; }

        public bool? AllowChangeDrawerStartAmount { get; set; }

        public bool? AllowEditCustomer { get; set; }

        public bool? AllowCustomerUnblock { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public bool? AllowBackOfficeEmployeeEditor { get; set; }

        public bool? AllowBackOfficePermissionEditor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionMapping> PermissionMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeSheet> TimeSheet { get; set; }
    }
}
