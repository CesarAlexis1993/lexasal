namespace LinkPosModelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextPosData : DbContext
    {
        public ContextPosData()
            : base("name=ContextPosData")
        {
        }

        public virtual DbSet<AddressCities> AddressCities { get; set; }
        public virtual DbSet<AddressPostalCodes> AddressPostalCodes { get; set; }
        public virtual DbSet<AddressStreets> AddressStreets { get; set; }
        public virtual DbSet<BankCheckLog> BankCheckLog { get; set; }
        public virtual DbSet<BarMenu> BarMenu { get; set; }
        public virtual DbSet<BarMenuSpecials> BarMenuSpecials { get; set; }
        public virtual DbSet<BarOptionals> BarOptionals { get; set; }
        public virtual DbSet<BarPrep> BarPrep { get; set; }
        public virtual DbSet<BarRecipeCategories> BarRecipeCategories { get; set; }
        public virtual DbSet<BarRecipes> BarRecipes { get; set; }
        public virtual DbSet<BarTabs> BarTabs { get; set; }
        public virtual DbSet<BlockedPhoneNumbers> BlockedPhoneNumbers { get; set; }
        public virtual DbSet<BusinessDayLog> BusinessDayLog { get; set; }
        public virtual DbSet<CallerIdEntries> CallerIdEntries { get; set; }
        public virtual DbSet<CashDrops> CashDrops { get; set; }
        public virtual DbSet<Combos> Combos { get; set; }
        public virtual DbSet<CompTypes> CompTypes { get; set; }
        public virtual DbSet<ConnectedTerminals> ConnectedTerminals { get; set; }
        public virtual DbSet<CreditCardTransactions> CreditCardTransactions { get; set; }
        public virtual DbSet<CreditCardTransactionTypes> CreditCardTransactionTypes { get; set; }
        public virtual DbSet<CustomerAccounts> CustomerAccounts { get; set; }
        public virtual DbSet<CustomerAccountTransactions> CustomerAccountTransactions { get; set; }
        public virtual DbSet<CustomerBookings> CustomerBookings { get; set; }
        public virtual DbSet<CustomerDetails> CustomerDetails { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DBUpdateStatus> DBUpdateStatus { get; set; }
        public virtual DbSet<Deliveries> Deliveries { get; set; }
        public virtual DbSet<DeliveryZones> DeliveryZones { get; set; }
        public virtual DbSet<DiscountAssignments> DiscountAssignments { get; set; }
        public virtual DbSet<Discounts> Discounts { get; set; }
        public virtual DbSet<DiscountsLog> DiscountsLog { get; set; }
        public virtual DbSet<dnImagePaths> dnImagePaths { get; set; }
        public virtual DbSet<DrawerCounts> DrawerCounts { get; set; }
        public virtual DbSet<DrawerCountTypes> DrawerCountTypes { get; set; }
        public virtual DbSet<DrawerResetLog> DrawerResetLog { get; set; }
        public virtual DbSet<DriverDeposits> DriverDeposits { get; set; }
        public virtual DbSet<EmployeeActions> EmployeeActions { get; set; }
        public virtual DbSet<EmployeeActionsLog> EmployeeActionsLog { get; set; }
        public virtual DbSet<EmployeeFingerprints> EmployeeFingerprints { get; set; }
        public virtual DbSet<EndOfDayReports> EndOfDayReports { get; set; }
        public virtual DbSet<ErrorsLog> ErrorsLog { get; set; }
        public virtual DbSet<EventPricing> EventPricing { get; set; }
        public virtual DbSet<ForeignCurrency> ForeignCurrency { get; set; }
        public virtual DbSet<ForeignLanguages> ForeignLanguages { get; set; }
        public virtual DbSet<GiftCards> GiftCards { get; set; }
        public virtual DbSet<GiftCardTransactions> GiftCardTransactions { get; set; }
        public virtual DbSet<Historicos_Legales> Historicos_Legales { get; set; }
        public virtual DbSet<HTMLTemplates> HTMLTemplates { get; set; }
        public virtual DbSet<ImageCategories> ImageCategories { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryAdjust> InventoryAdjust { get; set; }
        public virtual DbSet<InventoryAdjustReasons> InventoryAdjustReasons { get; set; }
        public virtual DbSet<InventoryAisles> InventoryAisles { get; set; }
        public virtual DbSet<InventoryCategories> InventoryCategories { get; set; }
        public virtual DbSet<InventoryItemAssignments> InventoryItemAssignments { get; set; }
        public virtual DbSet<InventoryReceived> InventoryReceived { get; set; }
        public virtual DbSet<InventoryTypes> InventoryTypes { get; set; }
        public virtual DbSet<InventoryUnits> InventoryUnits { get; set; }
        public virtual DbSet<InventoryUsage> InventoryUsage { get; set; }
        public virtual DbSet<ItemOptionals> ItemOptionals { get; set; }
        public virtual DbSet<ItemsOutOf> ItemsOutOf { get; set; }
        public virtual DbSet<ItemsRunningLow> ItemsRunningLow { get; set; }
        public virtual DbSet<ItemStatus> ItemStatus { get; set; }
        public virtual DbSet<ItemTypes> ItemTypes { get; set; }
        public virtual DbSet<KeyboardMap> KeyboardMap { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<Layouts> Layouts { get; set; }
        public virtual DbSet<LocationSettingsBoolean> LocationSettingsBoolean { get; set; }
        public virtual DbSet<LocationSettingsDate> LocationSettingsDate { get; set; }
        public virtual DbSet<LocationSettingsNumeric> LocationSettingsNumeric { get; set; }
        public virtual DbSet<LocationSettingsStrings> LocationSettingsStrings { get; set; }
        public virtual DbSet<LocationSettingsTime> LocationSettingsTime { get; set; }
        public virtual DbSet<LocationSettingsTypes> LocationSettingsTypes { get; set; }
        public virtual DbSet<LoyaltyCardPointsLog> LoyaltyCardPointsLog { get; set; }
        public virtual DbSet<LoyaltyCardTransactions> LoyaltyCardTransactions { get; set; }
        public virtual DbSet<MenuCategories> MenuCategories { get; set; }
        public virtual DbSet<MenuComboDefinitions> MenuComboDefinitions { get; set; }
        public virtual DbSet<MenuComboMap> MenuComboMap { get; set; }
        public virtual DbSet<MenuOptionalAssignments> MenuOptionalAssignments { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<MiscItems> MiscItems { get; set; }
        public virtual DbSet<NCFLookup> NCFLookup { get; set; }
        public virtual DbSet<NoSaleLog> NoSaleLog { get; set; }
        public virtual DbSet<NoSaleReasons> NoSaleReasons { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<NutritionInfo> NutritionInfo { get; set; }
        public virtual DbSet<OptionalGroups> OptionalGroups { get; set; }
        public virtual DbSet<OptionalLevels> OptionalLevels { get; set; }
        public virtual DbSet<Optionals> Optionals { get; set; }
        public virtual DbSet<OrderEventDefinitions> OrderEventDefinitions { get; set; }
        public virtual DbSet<OrderEvents> OrderEvents { get; set; }
        public virtual DbSet<OrderNotes> OrderNotes { get; set; }
        public virtual DbSet<OrderOptionals> OrderOptionals { get; set; }
        public virtual DbSet<OrderTypes> OrderTypes { get; set; }
        public virtual DbSet<PaidOutReasons> PaidOutReasons { get; set; }
        public virtual DbSet<PaidOutTransactions> PaidOutTransactions { get; set; }
        public virtual DbSet<PaidOutVendors> PaidOutVendors { get; set; }
        public virtual DbSet<PayRates> PayRates { get; set; }
        public virtual DbSet<PermissionMapping> PermissionMapping { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<PizzaIngredients> PizzaIngredients { get; set; }
        public virtual DbSet<PizzaIngredientSalesReport> PizzaIngredientSalesReport { get; set; }
        public virtual DbSet<PizzaIngredientsPricing> PizzaIngredientsPricing { get; set; }
        public virtual DbSet<PizzaMenuShortcuts> PizzaMenuShortcuts { get; set; }
        public virtual DbSet<PizzaMenuSpecials> PizzaMenuSpecials { get; set; }
        public virtual DbSet<PizzaPrep> PizzaPrep { get; set; }
        public virtual DbSet<PizzaSalesReport> PizzaSalesReport { get; set; }
        public virtual DbSet<PizzaSizes> PizzaSizes { get; set; }
        public virtual DbSet<PizzaStyles> PizzaStyles { get; set; }
        public virtual DbSet<PizzaStylesPricing> PizzaStylesPricing { get; set; }
        public virtual DbSet<PMSTransactions> PMSTransactions { get; set; }
        public virtual DbSet<PrepTicketLog> PrepTicketLog { get; set; }
        public virtual DbSet<QBUpdateLog> QBUpdateLog { get; set; }
        public virtual DbSet<QuickServeCustomers> QuickServeCustomers { get; set; }
        public virtual DbSet<RefundReasons> RefundReasons { get; set; }
        public virtual DbSet<Refunds> Refunds { get; set; }
        public virtual DbSet<RegularMenu> RegularMenu { get; set; }
        public virtual DbSet<RegularMenuSpecials> RegularMenuSpecials { get; set; }
        public virtual DbSet<RemoteDisplayLog> RemoteDisplayLog { get; set; }
        public virtual DbSet<RemoteMessages> RemoteMessages { get; set; }
        public virtual DbSet<RemovedItemReasons> RemovedItemReasons { get; set; }
        public virtual DbSet<RemovedItems> RemovedItems { get; set; }
        public virtual DbSet<Resoluciones> Resoluciones { get; set; }
        public virtual DbSet<Resoluciones_Tickets> Resoluciones_Tickets { get; set; }
        public virtual DbSet<RetailItemCategories> RetailItemCategories { get; set; }
        public virtual DbSet<RetailShortcuts> RetailShortcuts { get; set; }
        public virtual DbSet<RevenueCenters> RevenueCenters { get; set; }
        public virtual DbSet<RoomCharges> RoomCharges { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<ScheduleShifts> ScheduleShifts { get; set; }
        public virtual DbSet<SeatingChartDetails> SeatingChartDetails { get; set; }
        public virtual DbSet<SeatingCharts> SeatingCharts { get; set; }
        public virtual DbSet<ServerDeposits> ServerDeposits { get; set; }
        public virtual DbSet<SpecialEvents> SpecialEvents { get; set; }
        public virtual DbSet<SQLScripts> SQLScripts { get; set; }
        public virtual DbSet<StoreMessages> StoreMessages { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Taxes> Taxes { get; set; }
        public virtual DbSet<Temperatures> Temperatures { get; set; }
        public virtual DbSet<Terminals> Terminals { get; set; }
        public virtual DbSet<TicketAlerts> TicketAlerts { get; set; }
        public virtual DbSet<TicketDetails> TicketDetails { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<TimeSheet> TimeSheet { get; set; }
        public virtual DbSet<TimeSheetBreaks> TimeSheetBreaks { get; set; }
        public virtual DbSet<TipOfTheDay> TipOfTheDay { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<TransactionTypes> TransactionTypes { get; set; }
        public virtual DbSet<uiLoginButtons> uiLoginButtons { get; set; }
        public virtual DbSet<uiTicketButtons> uiTicketButtons { get; set; }
        public virtual DbSet<uiTransactionButtons> uiTransactionButtons { get; set; }
        public virtual DbSet<UpdateStatus> UpdateStatus { get; set; }
        public virtual DbSet<UserActions> UserActions { get; set; }
        public virtual DbSet<UserActionsLog> UserActionsLog { get; set; }
        public virtual DbSet<UserFingerprints> UserFingerprints { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserSettings> UserSettings { get; set; }
        public virtual DbSet<VoidReasons> VoidReasons { get; set; }
        public virtual DbSet<WebOrderReadyTime> WebOrderReadyTime { get; set; }
        public virtual DbSet<WebOrderStatus> WebOrderStatus { get; set; }
        public virtual DbSet<WordFilters> WordFilters { get; set; }
        public virtual DbSet<AdValorem> AdValorem { get; set; }
        public virtual DbSet<AgeVerificationLog> AgeVerificationLog { get; set; }
        public virtual DbSet<AgeVerificationMethods> AgeVerificationMethods { get; set; }
        public virtual DbSet<EndShiftLog> EndShiftLog { get; set; }
        public virtual DbSet<GiftCardServerLog> GiftCardServerLog { get; set; }
        public virtual DbSet<ReportDefinitions> ReportDefinitions { get; set; }
        public virtual DbSet<TabletServerCustomerReceipts> TabletServerCustomerReceipts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BarMenu>()
                .Property(e => e.TimeOn)
                .HasPrecision(0);

            modelBuilder.Entity<BarMenu>()
                .Property(e => e.TimeOff)
                .HasPrecision(0);

            modelBuilder.Entity<BarMenuSpecials>()
                .Property(e => e.StartTime)
                .HasPrecision(0);

            modelBuilder.Entity<BarMenuSpecials>()
                .Property(e => e.EndTime)
                .HasPrecision(0);

            modelBuilder.Entity<BarTabs>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<BusinessDayLog>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<CallerIdEntries>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<CashDrops>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<ConnectedTerminals>()
                .Property(e => e.TIME_ON)
                .HasPrecision(0);

            modelBuilder.Entity<CreditCardTransactions>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<CustomerAccounts>()
                .Property(e => e.DateCreated)
                .HasPrecision(0);

            modelBuilder.Entity<CustomerAccounts>()
                .Property(e => e.DateExpires)
                .HasPrecision(0);

            modelBuilder.Entity<CustomerAccountTransactions>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<CustomerBookings>()
                .Property(e => e.BookingDate)
                .HasPrecision(0);

            modelBuilder.Entity<CustomerBookings>()
                .Property(e => e.cbStartDate)
                .HasPrecision(0);

            modelBuilder.Entity<Customers>()
                .Property(e => e.CustomerSince)
                .HasPrecision(0);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.CustomerBookings)
                .WithOptional(e => e.Customers)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.CustomerDetails)
                .WithOptional(e => e.Customers)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DBUpdateStatus>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<Deliveries>()
                .Property(e => e.TimeOut)
                .HasPrecision(0);

            modelBuilder.Entity<Deliveries>()
                .Property(e => e.TimeIn)
                .HasPrecision(0);

            modelBuilder.Entity<Discounts>()
                .Property(e => e.StartDate)
                .HasPrecision(0);

            modelBuilder.Entity<Discounts>()
                .Property(e => e.EndDate)
                .HasPrecision(0);

            modelBuilder.Entity<Discounts>()
                .Property(e => e.StartTime)
                .HasPrecision(0);

            modelBuilder.Entity<Discounts>()
                .Property(e => e.EndTime)
                .HasPrecision(0);

            modelBuilder.Entity<Discounts>()
                .HasMany(e => e.DiscountAssignments)
                .WithOptional(e => e.Discounts)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DrawerResetLog>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<DriverDeposits>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<EmployeeActionsLog>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<ErrorsLog>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<EventPricing>()
                .Property(e => e.StartDateTime)
                .HasPrecision(0);

            modelBuilder.Entity<EventPricing>()
                .Property(e => e.FinishDateTime)
                .HasPrecision(0);

            modelBuilder.Entity<GiftCards>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<GiftCards>()
                .Property(e => e.Expires)
                .HasPrecision(0);

            modelBuilder.Entity<GiftCardTransactions>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.Fecha)
                .IsUnicode(false);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.ToVentasExentas)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.ToVentasGravadas)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.ToIVA)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.ToVentasSinIVA)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.ToPropina)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.VentasExenTicket)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.VentasGravTicket)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.VentasExenFac)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.VentasGravFac)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.FacInic)
                .IsUnicode(false);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.FacFin)
                .IsUnicode(false);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.VentasExenCCF)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.VentasGravCCF)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.CCFInic)
                .IsUnicode(false);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.CCFFIN)
                .IsUnicode(false);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.FechaFinal)
                .IsUnicode(false);

            modelBuilder.Entity<Historicos_Legales>()
                .Property(e => e.NumeroResolucion)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<InventoryAdjust>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<InventoryReceived>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<LocationSettingsDate>()
                .Property(e => e.SettingValue)
                .HasPrecision(0);

            modelBuilder.Entity<LocationSettingsTime>()
                .Property(e => e.SettingValue)
                .HasPrecision(0);

            modelBuilder.Entity<LoyaltyCardPointsLog>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<LoyaltyCardTransactions>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<MenuCategories>()
                .Property(e => e.TimeOn)
                .HasPrecision(0);

            modelBuilder.Entity<MenuCategories>()
                .Property(e => e.TimeOff)
                .HasPrecision(0);

            modelBuilder.Entity<MenuComboDefinitions>()
                .Property(e => e.StartTime)
                .HasPrecision(0);

            modelBuilder.Entity<MenuComboDefinitions>()
                .Property(e => e.EndTime)
                .HasPrecision(0);

            modelBuilder.Entity<MenuComboDefinitions>()
                .HasMany(e => e.MenuComboMap)
                .WithOptional(e => e.MenuComboDefinitions)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Menus>()
                .Property(e => e.TimeOn)
                .HasPrecision(0);

            modelBuilder.Entity<Menus>()
                .Property(e => e.TimeOff)
                .HasPrecision(0);

            modelBuilder.Entity<Menus>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Messages>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<MiscItems>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<NoSaleLog>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<PaidOutTransactions>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<Permissions>()
                .HasMany(e => e.PermissionMapping)
                .WithOptional(e => e.Permissions)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PizzaIngredients>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PizzaIngredientSalesReport>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PizzaIngredientsPricing>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PizzaMenuShortcuts>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PizzaMenuSpecials>()
                .Property(e => e.StartTime)
                .HasPrecision(0);

            modelBuilder.Entity<PizzaMenuSpecials>()
                .Property(e => e.EndTime)
                .HasPrecision(0);

            modelBuilder.Entity<PizzaMenuSpecials>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PizzaPrep>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PizzaSalesReport>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PizzaSizes>()
                .Property(e => e.TimeOn)
                .HasPrecision(0);

            modelBuilder.Entity<PizzaSizes>()
                .Property(e => e.TimeOff)
                .HasPrecision(0);

            modelBuilder.Entity<PizzaSizes>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PizzaSizes>()
                .HasMany(e => e.PizzaMenuShortcuts)
                .WithOptional(e => e.PizzaSizes)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PizzaStyles>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PizzaStyles>()
                .HasMany(e => e.PizzaMenuShortcuts)
                .WithOptional(e => e.PizzaStyles)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PizzaStylesPricing>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PMSTransactions>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<PrepTicketLog>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<QBUpdateLog>()
                .Property(e => e.BusinessDayStart)
                .HasPrecision(0);

            modelBuilder.Entity<QBUpdateLog>()
                .Property(e => e.BusinessDayEnd)
                .HasPrecision(0);

            modelBuilder.Entity<QBUpdateLog>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<Refunds>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<RegularMenu>()
                .Property(e => e.TimeOn)
                .HasPrecision(0);

            modelBuilder.Entity<RegularMenu>()
                .Property(e => e.TimeOff)
                .HasPrecision(0);

            modelBuilder.Entity<RegularMenu>()
                .HasMany(e => e.MenuComboMap)
                .WithOptional(e => e.RegularMenu)
                .HasForeignKey(e => e.MenuItemId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<RegularMenuSpecials>()
                .Property(e => e.StartTime)
                .HasPrecision(0);

            modelBuilder.Entity<RegularMenuSpecials>()
                .Property(e => e.EndTime)
                .HasPrecision(0);

            modelBuilder.Entity<RemoteDisplayLog>()
                .Property(e => e.SendDateTime)
                .HasPrecision(0);

            modelBuilder.Entity<RemoteDisplayLog>()
                .Property(e => e.BumpedDateTime)
                .HasPrecision(0);

            modelBuilder.Entity<RemoteMessages>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<RemovedItems>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<Resoluciones>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Resoluciones>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Resoluciones>()
                .Property(e => e.Activa)
                .IsUnicode(false);

            modelBuilder.Entity<Resoluciones>()
                .HasMany(e => e.Resoluciones_Tickets)
                .WithRequired(e => e.Resoluciones)
                .HasForeignKey(e => e.NumeroResolucion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resoluciones_Tickets>()
                .Property(e => e.Fecha)
                .IsUnicode(false);

            modelBuilder.Entity<Resoluciones_Tickets>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Resoluciones_Tickets>()
                .Property(e => e.NumeroResolucion)
                .IsUnicode(false);

            modelBuilder.Entity<RoomCharges>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<Schedule>()
                .Property(e => e.SchDate)
                .HasPrecision(0);

            modelBuilder.Entity<ScheduleShifts>()
                .Property(e => e.StartShift)
                .HasPrecision(0);

            modelBuilder.Entity<ScheduleShifts>()
                .Property(e => e.EndShift)
                .HasPrecision(0);

            modelBuilder.Entity<SeatingCharts>()
                .Property(e => e.TimeOn)
                .HasPrecision(0);

            modelBuilder.Entity<SeatingCharts>()
                .Property(e => e.TimeOff)
                .HasPrecision(0);

            modelBuilder.Entity<ServerDeposits>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<Terminals>()
                .Property(e => e.LastTimeOn)
                .HasPrecision(0);

            modelBuilder.Entity<TicketDetails>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<TicketDetails>()
                .Property(e => e.HoldDateTime)
                .HasPrecision(0);

            modelBuilder.Entity<Tickets>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<Tickets>()
                .Property(e => e.DelayOrderDateTime)
                .HasPrecision(0);

            modelBuilder.Entity<Tickets>()
                .Property(e => e.OrderStarted)
                .HasPrecision(0);

            modelBuilder.Entity<Tickets>()
                .HasMany(e => e.CreditCardTransactions)
                .WithOptional(e => e.Tickets)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Tickets>()
                .HasMany(e => e.DiscountsLog)
                .WithOptional(e => e.Tickets)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Tickets>()
                .HasMany(e => e.TicketDetails)
                .WithOptional(e => e.Tickets)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Tickets>()
                .HasMany(e => e.Transactions)
                .WithOptional(e => e.Tickets)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TimeSheet>()
                .Property(e => e.ShiftStart)
                .HasPrecision(0);

            modelBuilder.Entity<TimeSheet>()
                .Property(e => e.ShiftEnd)
                .HasPrecision(0);

            modelBuilder.Entity<TimeSheet>()
                .HasMany(e => e.TimeSheetBreaks)
                .WithOptional(e => e.TimeSheet)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TimeSheetBreaks>()
                .Property(e => e.BreakStart)
                .HasPrecision(0);

            modelBuilder.Entity<TimeSheetBreaks>()
                .Property(e => e.BreakEnd)
                .HasPrecision(0);

            modelBuilder.Entity<Transactions>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<UpdateStatus>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<UserActionsLog>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<UserFingerprints>()
                .Property(e => e.TimeDateStamp)
                .HasPrecision(0);

            modelBuilder.Entity<Users>()
                .Property(e => e.BirthDate)
                .HasPrecision(0);

            modelBuilder.Entity<Users>()
                .Property(e => e.DateHired)
                .HasPrecision(0);

            modelBuilder.Entity<Users>()
                .Property(e => e.DateReleased)
                .HasPrecision(0);

            modelBuilder.Entity<Users>()
                .Property(e => e.DriverLicenseExpires)
                .HasPrecision(0);

            modelBuilder.Entity<Users>()
                .Property(e => e.AutoInsuranceExpires)
                .HasPrecision(0);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.PermissionMapping)
                .WithOptional(e => e.Users)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserActionsLog)
                .WithOptional(e => e.Users)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserFingerprints)
                .WithOptional(e => e.Users)
                .WillCascadeOnDelete();

            modelBuilder.Entity<AdValorem>()
                .Property(e => e.MenuCategoryText)
                .IsUnicode(false);

            modelBuilder.Entity<AdValorem>()
                .Property(e => e.CATEGORIAMH)
                .IsUnicode(false);
        }
    }
}
