namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ForeignLanguages
    {
        [Key]
        public int ForeignLanguageId { get; set; }

        [StringLength(1000)]
        public string EnglishText { get; set; }

        [StringLength(1000)]
        public string Language1 { get; set; }

        [StringLength(1000)]
        public string Language2 { get; set; }

        [StringLength(1000)]
        public string Language3 { get; set; }

        [StringLength(1000)]
        public string Language4 { get; set; }

        [StringLength(1000)]
        public string Language5 { get; set; }

        [StringLength(1000)]
        public string Language6 { get; set; }

        [StringLength(1000)]
        public string Language7 { get; set; }

        [StringLength(1000)]
        public string Language8 { get; set; }

        [StringLength(1000)]
        public string Language9 { get; set; }

        [StringLength(1000)]
        public string Language10 { get; set; }

        [StringLength(1000)]
        public string Language11 { get; set; }

        [StringLength(1000)]
        public string Language12 { get; set; }

        [StringLength(1000)]
        public string Language13 { get; set; }

        [StringLength(1000)]
        public string Language14 { get; set; }

        [StringLength(1000)]
        public string Language15 { get; set; }

        [StringLength(1000)]
        public string Language16 { get; set; }

        [StringLength(1000)]
        public string Language17 { get; set; }

        [StringLength(1000)]
        public string Language18 { get; set; }

        [StringLength(1000)]
        public string Language19 { get; set; }

        [StringLength(1000)]
        public string Language20 { get; set; }

        [StringLength(1000)]
        public string Language21 { get; set; }

        [StringLength(1000)]
        public string Language22 { get; set; }

        [StringLength(1000)]
        public string Language23 { get; set; }

        [StringLength(1000)]
        public string Language24 { get; set; }

        [StringLength(1000)]
        public string Language25 { get; set; }

        [StringLength(1000)]
        public string Language26 { get; set; }

        public int? ScreenID { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
