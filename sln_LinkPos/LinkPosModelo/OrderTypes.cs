namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderTypes
    {
        [Key]
        public int OrderTypeId { get; set; }

        [StringLength(50)]
        public string OrderType { get; set; }

        public int? ButtonPosition { get; set; }

        public int? ButtonImageId { get; set; }

        public bool? Disable { get; set; }

        public int? StartupCategories { get; set; }

        public int? SurchargeType { get; set; }

        [StringLength(50)]
        public string SurchargeText { get; set; }

        public double? SurchargeAmount { get; set; }

        public int SurchargeTaxRateId { get; set; }

        public bool? ChargeTakeoutContainers { get; set; }

        public bool? NonTaxable { get; set; }

        public bool? TaxInclusive { get; set; }

        public bool? MandatoryGratuity { get; set; }

        public double? GratuityAmount { get; set; }

        public bool? IncludeTaxInGratuityCalculation { get; set; }

        public bool? ExcludeDiscountFromMandatoryGratuity { get; set; }

        public int? MinimumGuestsForGratuity { get; set; }

        public bool? PrintSuggestedGratuities { get; set; }

        public bool? PrintBlockLettersTop { get; set; }

        public bool? PrintBlockLettersBottom { get; set; }

        public bool? PrintBlockLettersRemoteTop { get; set; }

        public bool? PrintBlockLettersRemoteBottom { get; set; }

        public bool? PrintLargeTicketIdAtBottom { get; set; }

        public bool? PrintTicketItemCount { get; set; }

        public bool? PrintLabels { get; set; }

        public bool? ShowRooms { get; set; }

        public bool? ShowGuestSelect { get; set; }

        public bool? ShowCustomerInfo { get; set; }

        public bool? ShowDeliveryZones { get; set; }

        public bool? ShowPhoneNumber { get; set; }

        public bool? ForceBeverageSelection { get; set; }

        public bool? StayOnOrderEntryScreen { get; set; }

        public bool? AutoPrintReceipt { get; set; }

        public bool? LoyaltyCardPrompt { get; set; }

        public bool? QSCustomerNamePrompt { get; set; }

        public bool? BarMenuTaxIncluded { get; set; }

        public int? RemoteDisplayColor { get; set; }

        public int? RemoteDisplayTextColor { get; set; }

        public int? DefaultMenuCategoryId { get; set; }

        public bool? GuestAssignmentEnabled { get; set; }

        public bool? SRMCounterMode { get; set; }

        public bool? UseExactChangeForCash { get; set; }

        public bool? IncludeInMinimumTipDeclaration { get; set; }

        public bool? CallCenterEnabled { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
