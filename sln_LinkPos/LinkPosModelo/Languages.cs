namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Languages
    {
        public int ID { get; set; }

        public int? LanguageId { get; set; }

        [StringLength(50)]
        public string LanguageName { get; set; }

        public int? CharacterSetId { get; set; }

        public int? PrintCodePage { get; set; }

        [StringLength(6)]
        public string MSLanguageCode { get; set; }

        public bool? IsRightToLeft { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
