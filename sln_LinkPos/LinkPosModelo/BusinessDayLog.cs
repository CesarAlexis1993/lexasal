namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessDayLog")]
    public partial class BusinessDayLog
    {
        [Key]
        public int LogId { get; set; }

        public int? UserId { get; set; }

        public string TextReport { get; set; }

        [StringLength(255)]
        public string HistoricalNotes { get; set; }

        public int? WeatherImageId { get; set; }

        public int? TemperatureId { get; set; }

        public int? SpecialEventId { get; set; }

        public bool? Void { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeDateStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
