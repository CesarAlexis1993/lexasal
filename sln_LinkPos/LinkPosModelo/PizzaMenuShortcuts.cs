namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PizzaMenuShortcuts
    {
        [Key]
        public int PizzaShortcutId { get; set; }

        [StringLength(50)]
        public string ButtonCaption { get; set; }

        public int? PizzaSizeId { get; set; }

        public int? PizzaStyleId { get; set; }

        public int? ButtonPosition { get; set; }

        public int? ButtonColor { get; set; }

        public int? BorderColor { get; set; }

        public int? FontColor { get; set; }

        public bool? Disable { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual PizzaSizes PizzaSizes { get; set; }

        public virtual PizzaStyles PizzaStyles { get; set; }
    }
}
