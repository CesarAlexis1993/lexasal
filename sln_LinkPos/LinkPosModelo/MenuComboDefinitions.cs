namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MenuComboDefinitions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenuComboDefinitions()
        {
            MenuComboMap = new HashSet<MenuComboMap>();
        }

        [Key]
        public int MenuComboId { get; set; }

        [StringLength(50)]
        public string MenuComboName { get; set; }

        public double? Price { get; set; }

        public int? TaxRateId { get; set; }

        public bool? Disabled { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndTime { get; set; }

        public bool? Day1 { get; set; }

        public bool? Day2 { get; set; }

        public bool? Day3 { get; set; }

        public bool? Day4 { get; set; }

        public bool? Day5 { get; set; }

        public bool? Day6 { get; set; }

        public bool? Day7 { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuComboMap> MenuComboMap { get; set; }
    }
}
