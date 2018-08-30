using LinkPosControl.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkPos
{
    public partial class Facturacion : Form
    {
        private long OrderID;
        private FacturacionControl control;

        public Facturacion()
        {
            InitializeComponent();
        }

        public Facturacion(long OrderID)
        {
            InitializeComponent();
            control = new FacturacionControl();
            this.OrderID = OrderID;
        }

        private void btnTck_Click(object sender, EventArgs e)
        {
            ImprimirDocumento(OrderID, "TCK");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCcf_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            lblNumOrden.Text = this.OrderID.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private DialogResult ImprimirDocumento(long OrderID,string TipoDocumento)
        {
            if(control.ImprimirDocumento(OrderID, TipoDocumento))
            {
                return DialogResult.OK;
            }
            else
            {
                return DialogResult.No;
            }
        }
    }
}
