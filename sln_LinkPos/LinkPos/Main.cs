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
            try
            {
                Facturacion factu = new Facturacion(41);
                factu.FormBorderStyle = FormBorderStyle.None;
                factu.ShowDialog();

                if (factu.DialogResult == DialogResult.OK)
                {
                    
                }
                else
                {

                }

            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
