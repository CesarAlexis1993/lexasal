using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinkPosUtils
{
    public class Configuracion
    {
        public static PosConfig Obtener()
        {
            List<string> lstEncabezado = new List<string>();
            List<string> lstPie = new List<string>();

            XmlDocument xDoc = new XmlDocument();
            PosConfig Config = new PosConfig();
            string dirdoc;

            try
            {
                dirdoc = Path.Combine(Directory.GetCurrentDirectory(), "PosConfig.xml");

                if (File.Exists(dirdoc))
                {
                    xDoc.Load(dirdoc);
                    XmlNodeList xConfig = xDoc.GetElementsByTagName("appconfig");
                    XmlNodeList xEncabezado = xDoc.GetElementsByTagName("encabezado");
                    XmlNodeList xPieDoc = xDoc.GetElementsByTagName("pie");

                    foreach (XmlElement cnf in xConfig)
                    {
                        Config.NomApp = cnf.SelectSingleNode("nomapp").InnerText.Trim();
                        Config.NomEmpre = cnf.SelectSingleNode("nomempre").InnerText.Trim();
                        Config.Giro = cnf.SelectSingleNode("giro").InnerText.Trim();
                        Config.NomComer = cnf.SelectSingleNode("nomcomer").InnerText.Trim();
                        Config.Sucursal = cnf.SelectSingleNode("sucursal").InnerText.Trim();
                        Config.DbProv = cnf.SelectSingleNode("dbprov").InnerText.Trim();
                        Config.DbRuta = cnf.SelectSingleNode("dbruta").InnerText.Trim();
                        Config.NumCaja = int.Parse(cnf.SelectSingleNode("nocaja").InnerText.Trim());
                        Config.Prt_Tck = cnf.SelectSingleNode("prt_tck").InnerText.Trim();
                        Config.Prt_Doc = cnf.SelectSingleNode("prt_doc").InnerText.Trim();
                        Config.NomFont = cnf.SelectSingleNode("nomfont").InnerText.Trim();
                        Config.NomFontDoc = cnf.SelectSingleNode("nomfont_doc").InnerText.Trim();
                        Config.CantCar_Tck = int.Parse(cnf.SelectSingleNode("cantcar_tck").InnerText.Trim());
                        Config.CantCar_Doc = int.Parse(cnf.SelectSingleNode("cantcar_doc").InnerText.Trim());
                        Config.Lineas_Doc = int.Parse(cnf.SelectSingleNode("lineas_doc").InnerText.Trim());
                        Config.SpcInicio = int.Parse(cnf.SelectSingleNode("spcinicio_doc").InnerText.Trim());
                        Config.FontSize_Tck = double.Parse(cnf.SelectSingleNode("fntsize_tck").InnerText.Trim());
                        Config.FontSize_Doc = double.Parse(cnf.SelectSingleNode("fntsize_doc").InnerText.Trim());

                        if (cnf.SelectSingleNode("fntbold").InnerText.Trim() == "1")
                        {
                            Config.FontBold = true;
                        }
                        else
                        {
                            Config.FontBold = false;
                        }

                        Config.SepDoc = cnf.SelectSingleNode("sepdoc").InnerText.Trim();
                        Config.SepLine = cnf.SelectSingleNode("sepline").InnerText.Trim();
                        Config.SimbMone = cnf.SelectSingleNode("simbmone").InnerText.Trim();
                        Config.NomMone = cnf.SelectSingleNode("nombmone").InnerText.Trim();
                        Config.Impuesto1 = double.Parse(cnf.SelectSingleNode("impuesto1").InnerText.Trim());
                    }

                    foreach (XmlElement e in xEncabezado)
                    {
                        foreach (XmlNode nodo in e.ChildNodes)
                        {
                            if (nodo.InnerText.Trim().Length > 0)
                            {
                                lstEncabezado.Add(nodo.InnerText.Trim());
                            }
                        }
                    }

                    Config.Encabezado = lstEncabezado;

                    foreach (XmlElement p in xPieDoc)
                    {
                        foreach (XmlNode nodo in p.ChildNodes)
                        {
                            if (nodo.InnerText.Trim().Length > 0)
                            {
                                lstPie.Add(nodo.InnerText.Trim());
                            }
                        }
                    }

                    Config.Pie = lstPie;

                }

            }
            catch (Exception e)
            {
                throw new Exception("Se ha producido un error al intentar cargar las configuraciones del sistema: " + e.Message);
            }

            return Config;
        }
    }
}
