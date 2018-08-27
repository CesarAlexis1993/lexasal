namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Taxes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxRateId { get; set; }

        public bool? Enabled { get; set; }

        [StringLength(50)]
        public string TaxName { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        [StringLength(20)]
        public string Tax1Alias { get; set; }

        [StringLength(50)]
        public string Tax1Abb { get; set; }

        public double? Tax1Value { get; set; }

        public double? Tax1Minimum { get; set; }

        [StringLength(20)]
        public string Tax2Alias { get; set; }

        [StringLength(50)]
        public string Tax2Abb { get; set; }

        public double? Tax2Value { get; set; }

        public double? Tax2Minimum { get; set; }

        [StringLength(20)]
        public string Tax3Alias { get; set; }

        [StringLength(50)]
        public string Tax3Abb { get; set; }

        public double? Tax3Value { get; set; }

        public double? Tax3Minimum { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
