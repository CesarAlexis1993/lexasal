namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ForeignCurrency")]
    public partial class ForeignCurrency
    {
        public int ForeignCurrencyId { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Symbol { get; set; }

        [StringLength(50)]
        public string CurrencyName { get; set; }

        [StringLength(50)]
        public string Abbreviation { get; set; }

        public bool? Enabled { get; set; }

        public bool? ShowOnReceipt { get; set; }

        public double? ExchangeRate { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
