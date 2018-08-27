using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalTriggers
{
    public class CustomerReceiptTrigger
    {
        public bool PrintCustomerReceipt(long OrderID)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
