using LinkPosModelo;
using LinkPosUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkPosControl.Vistas
{
    public class FacturacionControl
    {
        private DataPos contexdb;

        public FacturacionControl()
        {
            contexdb = new DataPos();
        }

        public List<string> CrearDocumento(long OrdeID,string TipoDoc)
        {
            List<string> ls = new List<string>();

            try
            {
                //Tickets t = contexdb.Get<Tickets>(x => x.TicketId == OrdeID);
                foreach(string s in Config.Obtener.Encabezado)
                {
                    ls.Add(Texto.Centrar(s, Config.Obtener.CantCar_Tck));
                }

                return ls;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ImprimirDocumento(long OrderID,string TipoDoc)
        {
            bool bandera = false;
            StringBuilder sb;
            PosImpresor print = new PosImpresor();

            try
            {
                print.Imprimir(CrearDocumento(OrderID, TipoDoc), TipoDoc);
                return bandera;
            }catch(Exception e)
            {
                throw new Exception("Se ha generado el siguente error al intentar imprimir el documento: " + e.Message);
            }

        }
    }
}
