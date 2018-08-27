namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PizzaStylesPricing")]
    public partial class PizzaStylesPricing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PizzaStylesPricing()
        {
            PizzaStyles = new HashSet<PizzaStyles>();
        }

        [Key]
        public int StylePriceGroupId { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public bool? EnablePriceLevel1 { get; set; }

        public double? PriceLevel1 { get; set; }

        public bool? EnablePriceLevel2 { get; set; }

        public double? PriceLevel2 { get; set; }

        public bool? EnablePriceLevel3 { get; set; }

        public double? PriceLevel3 { get; set; }

        public bool? EnablePriceLevel4 { get; set; }

        public double? PriceLevel4 { get; set; }

        public bool? EnablePriceLevel5 { get; set; }

        public double? PriceLevel5 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PizzaStyles> PizzaStyles { get; set; }
    }
}
