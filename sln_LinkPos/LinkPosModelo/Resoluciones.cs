namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Resoluciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resoluciones()
        {
            Resoluciones_Tickets = new HashSet<Resoluciones_Tickets>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdResolucion { get; set; }

        [Key]
        [StringLength(100)]
        public string Numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(100)]
        public string Serie { get; set; }

        public int Caja { get; set; }

        public long RangoInicial { get; set; }

        public long RangoFinal { get; set; }

        public decimal PorcentajeAlerta { get; set; }

        [Required]
        [StringLength(10)]
        public string Activa { get; set; }

        public long? NumActual { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resoluciones_Tickets> Resoluciones_Tickets { get; set; }
    }
}
