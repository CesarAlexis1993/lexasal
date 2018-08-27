namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransactionTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransactionTypes()
        {
            Transactions = new HashSet<Transactions>();
        }

        [Key]
        public int TransactionTypeId { get; set; }

        [StringLength(50)]
        public string TransactionType { get; set; }

        public int? ButtonPosition { get; set; }

        public bool? Disable { get; set; }

        public bool? OpenDrawer { get; set; }

        public bool? Deduct { get; set; }

        public bool? ShowSettle { get; set; }

        public int? ImageId { get; set; }

        public bool? ShowBankCheckPrompt { get; set; }

        public bool? ShowManualCreditCardPrompt { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
