namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Discounts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Discounts()
        {
            DiscountAssignments = new HashSet<DiscountAssignments>();
        }

        [Key]
        public int DiscountId { get; set; }

        [StringLength(50)]
        public string DiscountName { get; set; }

        public int? ButtonPosition { get; set; }

        [StringLength(50)]
        public string PrintText { get; set; }

        public int? Method { get; set; }

        public double? Amount { get; set; }

        public int? Calculation { get; set; }

        public bool? Disable { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndTime { get; set; }

        public double? OrderMinimum { get; set; }

        public int? OrderTypeId { get; set; }

        public int? IdenticalDiscountsPerTicket { get; set; }

        public int? ItemsPerTicket { get; set; }

        public bool? AllowOtherDiscounts { get; set; }

        public bool? MenuItemAssignment { get; set; }

        public bool? PizzaSizeStyle { get; set; }

        public int? RequiredChoices { get; set; }

        [StringLength(50)]
        public string SKU { get; set; }

        public bool? Automatic { get; set; }

        public bool? Day1 { get; set; }

        public bool? Day2 { get; set; }

        public bool? Day3 { get; set; }

        public bool? Day4 { get; set; }

        public bool? Day5 { get; set; }

        public bool? Day6 { get; set; }

        public bool? Day7 { get; set; }

        public bool? ExcludeBarItems { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountAssignments> DiscountAssignments { get; set; }
    }
}
