namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReportDefinitions
    {
        [Key]
        [Column(Order = 0)]
        public int ReportDefinitionID { get; set; }

        [StringLength(50)]
        public string ButtonText { get; set; }

        public bool? IsEnabled { get; set; }

        public int? ImageID { get; set; }

        public string ReportDefinition { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
