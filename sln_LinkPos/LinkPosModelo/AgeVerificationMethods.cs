namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AgeVerificationMethods
    {
        [Key]
        [Column(Order = 0)]
        public int AgeVerificationMethodID { get; set; }

        [StringLength(25)]
        public string AgeVerificationMethod { get; set; }

        public int? ButtonPosition { get; set; }

        public bool? ShowKeyboard { get; set; }

        [StringLength(35)]
        public string KeyboardPrompt { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
