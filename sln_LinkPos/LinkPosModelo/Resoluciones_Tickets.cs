namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Resoluciones_Tickets
    {
        [Key]
        public int IdRegistro { get; set; }

        [StringLength(50)]
        public string Fecha { get; set; }

        public int IdOrden { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoDocumento { get; set; }

        public long NumeroDocumento { get; set; }

        [Required]
        [StringLength(100)]
        public string NumeroResolucion { get; set; }

        public int NumeroCaja { get; set; }

        public long? TicketReemplazado { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }

        public virtual Resoluciones Resoluciones { get; set; }
    }
}
