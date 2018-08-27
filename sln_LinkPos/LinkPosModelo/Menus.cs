namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Menus
    {
        [Key]
        public int MenuId { get; set; }

        [Required]
        [StringLength(50)]
        public string MenuName { get; set; }

        [StringLength(50)]
        public string MenuShortName { get; set; }

        public bool? Disable { get; set; }

        public bool? LargeCategoryButtons { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOff { get; set; }

        public int? DefaultCategoryId { get; set; }

        public int? BeverageCategoryId { get; set; }

        public bool? Day1 { get; set; }

        public bool? Day2 { get; set; }

        public bool? Day3 { get; set; }

        public bool? Day4 { get; set; }

        public bool? Day5 { get; set; }

        public bool? Day6 { get; set; }

        public bool? Day7 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
