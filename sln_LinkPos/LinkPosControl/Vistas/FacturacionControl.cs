using LinkPosModelo;
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

        public StringBuilder GenerarDocumento(long OrdeID,string TipoDoc)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                Tickets t = contexdb.Get<Tickets>(x => x.TicketId == OrdeID);
                sb.Append(t.TimeDateStamp.ToString() + " - " + t.Users.FirstName);
                return sb;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
