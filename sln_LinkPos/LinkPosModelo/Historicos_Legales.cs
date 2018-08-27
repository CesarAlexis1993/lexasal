namespace LinkPosModelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Historicos_Legales
    {
        [Key]
        public int IdRegistro { get; set; }

        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [StringLength(50)]
        public string Fecha { get; set; }

        public long? TicketNo { get; set; }

        public decimal? ToVentasExentas { get; set; }

        public decimal? ToVentasGravadas { get; set; }

        public decimal? ToIVA { get; set; }

        public decimal? ToVentasSinIVA { get; set; }

        public decimal? ToPropina { get; set; }

        public decimal? VentasExenTicket { get; set; }

        public decimal? VentasGravTicket { get; set; }

        public long? TicketInic { get; set; }

        public long? TicketFin { get; set; }

        public long? ToTicket { get; set; }

        public decimal? VentasExenFac { get; set; }

        public decimal? VentasGravFac { get; set; }

        [StringLength(200)]
        public string FacInic { get; set; }

        [StringLength(200)]
        public string FacFin { get; set; }

        public long? ToFac { get; set; }

        public decimal? VentasExenCCF { get; set; }

        public decimal? VentasGravCCF { get; set; }

        [StringLength(200)]
        public string CCFInic { get; set; }

        [StringLength(200)]
        public string CCFFIN { get; set; }

        public long? ToCCF { get; set; }

        [StringLength(50)]
        public string FechaFinal { get; set; }

        public int? Mes { get; set; }

        public int? Yr { get; set; }

        [Required]
        [StringLength(100)]
        public string NumeroResolucion { get; set; }

        public int NumeroCaja { get; set; }

        public Guid RowGuid { get; set; }

        public bool? IsSynced { get; set; }

        [StringLength(36)]
        public string StoreId { get; set; }
    }
}
