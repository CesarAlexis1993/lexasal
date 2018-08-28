using LinkPos;
using System;
using System.Windows.Forms;

namespace ExternalTriggers
{
    public class CustomerReceiptTrigger
    {
        public bool PrintCustomerReceipt(long OrderID)
        {
            try
            {
                Facturacion factu = new Facturacion(OrderID);
                factu.FormBorderStyle = FormBorderStyle.None;
                factu.ShowDialog();

                if (factu.DialogResult== DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
