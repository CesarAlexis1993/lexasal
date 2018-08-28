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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            try
            {
                Facturacion factu = new Facturacion(44);
                factu.FormBorderStyle = FormBorderStyle.None;
                factu.ShowDialog();

                if (factu.DialogResult == DialogResult.OK)
                {
                    bandera= true;
                }
                else
                {
                    bandera= false;
                }

            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
