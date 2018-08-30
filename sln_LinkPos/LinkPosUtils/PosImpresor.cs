using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace LinkPosUtils
{
    public class PosImpresor
    {
        private Font printFont;

        private int i = 0;
        private List<string> _lista;

        private int lnxpagina = 0;
        private int Paginas;

        public PosImpresor()
        {
            Init();
        }

        private void Init()
        {
            lnxpagina = 0;
            printFont = new Font(Config.Obtener.NomFont, (float)Config.Obtener.FontSize_Tck);
        }

        public int LineasPagina(string tpdoc)
        {
            string pname;
            if (tpdoc.Equals("CCF") || tpdoc.Equals("FAC"))
            {
                pname = Config.Obtener.Prt_Doc;
            }
            else
            {
                pname = Config.Obtener.Prt_Tck;
            }

            PrinterSettings settings = new PrinterSettings();
            settings.PrinterName = pname;
            lnxpagina = (int)(settings.DefaultPageSettings.Bounds.Height / printFont.GetHeight(settings.CreateMeasurementGraphics()));
            return lnxpagina;
        }

        public void Imprimir(List<string> lista, string tpdoc)
        {
            string ndoc;
            string pname;

            try
            {
                ndoc = "DOC_" + tpdoc;

                if (tpdoc.Equals("CCF") || tpdoc.Equals("FAC"))
                {
                    pname = Config.Obtener.Prt_Doc;
                }
                else
                {
                    pname = Config.Obtener.Prt_Tck;
                }

                LineasPagina(tpdoc);

                _lista = lista;
                PrintDocument pd = new PrintDocument();
                pd.PrintController = new StandardPrintController();
                pd.DocumentName = ndoc;
                pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                pd.PrinterSettings.PrinterName = pname;
                pd.PrintPage += new PrintPageEventHandler(this.print_page);
                pd.Print();

            }
            catch (Exception ex)
            {
                throw new Exception("Se ha producido un error al intentar imprimir el texto " + ex.Message);
            }
        }

        private void print_page(object sender, PrintPageEventArgs ev)
        {

            float ypos = 0;
            int contador = 0;
            string txtlinea = "";

            float leftmargin = ev.MarginBounds.Left;
            float topmargin = ev.MarginBounds.Top;

            while ((contador < lnxpagina) && (i <= _lista.Count))
            {
                if (i < _lista.Count)
                {
                    txtlinea = _lista[i];
                    ypos = topmargin + (contador * printFont.GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(txtlinea, printFont, Brushes.Black, leftmargin, ypos, new StringFormat());
                }
                contador++;
                i++;
            }


            if (i <= _lista.Count)
            {
                ev.HasMorePages = true;
                Paginas++;
            }
            else
            {
                ev.HasMorePages = false;
            }


        }

        public int PaginasDoc(double totlineas, int lineasdoc)
        {
            int p = 0;
            decimal n1 = 0;
            decimal n2 = 0;

            n1 = Convert.ToDecimal(totlineas / lineasdoc);
            n2 = n1 - (Convert.ToInt32(n1));

            p = (Convert.ToInt32(n1));

            if (n2 != 0)
            {
                p = p + 1;
            }

            return p;
        }
    }
}
