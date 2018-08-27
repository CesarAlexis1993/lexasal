using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalTriggers
{
    public class CashDrawerTrigger
    {
        public bool RunCashDrawerReset(long DrawerResetID)
        {
            bool bandera = false;

            try
            {
                bandera = true;
            }
            catch
            {
                bandera = false;
            }
            return bandera;
        }
    }
}
