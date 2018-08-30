using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkPosUtils
{
    public class PosConfig
    {
        #region Configuraciones de la Aplicacion

        public string NomApp { get; set; }
        public string NomEmpre { get; set; }
        public string Giro { get; set; }
        public string NomComer { get; set; }
        public string Sucursal { get; set; }
        public string DbProv { get; set; }
        public string DbRuta { get; set; }
        public int NumCaja { get; set; }
        public string Prt_Tck { get; set; }
        public string Prt_Doc { get; set; }
        public string NomFont { get; set; }
        public string NomFontDoc { get; set; }
        public int CantCar_Tck { get; set; }
        public int CantCar_Doc { get; set; }
        public int Lineas_Doc { get; set; }
        public int SpcInicio { get; set; }
        public double FontSize_Tck { get; set; }
        public double FontSize_Doc { get; set; }
        public bool FontBold { get; set; }
        public string SepDoc { get; set; }
        public string SepLine { get; set; }
        public string SimbMone { get; set; }
        public string NomMone { get; set; }
        public double Impuesto1 { get; set; }

        #endregion

        #region Encabezado y pie de documento
        public List<string> Encabezado { get; set; }
        public List<string> Pie { get; set; }
        #endregion
    }
}
