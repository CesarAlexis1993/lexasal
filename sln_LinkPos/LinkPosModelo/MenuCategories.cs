namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MenuCategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenuCategories()
        {
            RegularMenu = new HashSet<RegularMenu>();
        }

        [Key]
        public int MenuCategoryId { get; set; }

        [StringLength(50)]
        public string MenuCategoryName { get; set; }

        [StringLength(50)]
        public string Language2 { get; set; }

        public int? ButtonPosition { get; set; }

        public int? MenuId { get; set; }

        public int? MenuTypeId { get; set; }

        public int? Visibility { get; set; }

        public int? ButtonImageId { get; set; }

        public bool? Day1 { get; set; }

        public bool? Day2 { get; set; }

        public bool? Day3 { get; set; }

        public bool? Day4 { get; set; }

        public bool? Day5 { get; set; }

        public bool? Day6 { get; set; }

        public bool? Day7 { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOff { get; set; }

        public double? Markup { get; set; }

        public int? TaxRateId { get; set; }

        public bool? Upcharge1 { get; set; }

        [StringLength(50)]
        public string Upcharge1Desc { get; set; }

        [StringLength(50)]
        public string Upcharge1Prefix { get; set; }

        [StringLength(50)]
        public string Upcharge1Suffix { get; set; }

        public bool? Upcharge2 { get; set; }

        [StringLength(50)]
        public string Upcharge2Desc { get; set; }

        [StringLength(50)]
        public string Upcharge2Prefix { get; set; }

        [StringLength(50)]
        public string Upcharge2Suffix { get; set; }

        public bool? Upcharge3 { get; set; }

        [StringLength(50)]
        public string Upcharge3Desc { get; set; }

        [StringLength(50)]
        public string Upcharge3Prefix { get; set; }

        [StringLength(50)]
        public string Upcharge3Suffix { get; set; }

        public bool? Upcharge4 { get; set; }

        [StringLength(50)]
        public string Upcharge4Desc { get; set; }

        [StringLength(50)]
        public string Upcharge4Prefix { get; set; }

        [StringLength(50)]
        public string Upcharge4Suffix { get; set; }

        public bool? Upcharge5 { get; set; }

        [StringLength(50)]
        public string Upcharge5Desc { get; set; }

        [StringLength(50)]
        public string Upcharge5Prefix { get; set; }

        [StringLength(50)]
        public string Upcharge5Suffix { get; set; }

        public bool? Upcharge6 { get; set; }

        [StringLength(50)]
        public string Upcharge6Desc { get; set; }

        [StringLength(50)]
        public string Upcharge6Prefix { get; set; }

        [StringLength(50)]
        public string Upcharge6Suffix { get; set; }

        public bool? ExcludeFromSpecialPricing { get; set; }

        public bool? ExcludeFromEventPricing { get; set; }

        public double? Upcharge1Inventory { get; set; }

        public double? Upcharge2Inventory { get; set; }

        public double? Upcharge3Inventory { get; set; }

        public double? Upcharge4Inventory { get; set; }

        public double? Upcharge5Inventory { get; set; }

        public double? Upcharge6Inventory { get; set; }

        public int? Availability { get; set; }

        [StringLength(255)]
        public string WebDescription { get; set; }

        [StringLength(50)]
        public string dnButtonBackground { get; set; }

        [StringLength(50)]
        public string dnButtonImagePathFill { get; set; }

        [StringLength(50)]
        public string dnButtonForeground { get; set; }

        public int? dnImageType { get; set; }

        public int? dnImagePathID { get; set; }

        public bool? AlwaysShowBarModifiers { get; set; }

        public bool? TakeoutNonTaxable { get; set; }

        public int? MinimumAgeVerification { get; set; }

        public int? VisibleColumns { get; set; }

        public int? VisibleRows { get; set; }

        public bool? IsRetail { get; set; }

        public string VectorImage { get; set; }

        public byte[] BitmapImage { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegularMenu> RegularMenu { get; set; }
    }
}
