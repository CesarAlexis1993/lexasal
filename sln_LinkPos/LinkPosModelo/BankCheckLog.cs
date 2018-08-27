namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankCheckLog")]
    public partial class BankCheckLog
    {
        public int BankCheckLogId { get; set; }

        public int? DrawerResetId { get; set; }

        public int? CheckNumber { get; set; }

        public double? CheckAmount { get; set; }

        public bool? Returned { get; set; }

        public int? CustomerId { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
