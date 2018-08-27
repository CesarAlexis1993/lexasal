namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventPricing")]
    public partial class EventPricing
    {
        [Key]
        public int EventId { get; set; }

        [StringLength(200)]
        public string EventName { get; set; }

        public bool? Disable { get; set; }

        public int? MenuType { get; set; }

        public double? AddAmount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FinishDateTime { get; set; }

        public int? SpecialType { get; set; }

        public bool? ShowOnManagerScreen { get; set; }

        public bool? DisableAtEndOfDay { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
