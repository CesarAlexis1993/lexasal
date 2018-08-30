using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkPosUtils
{
    public class Texto
    {
        public static string Agregar(string texto, int caracteres)
        {
            try
            {
                texto = texto.Trim();

                if (texto.Length > caracteres)
                {
                    texto = texto.Substring(0, caracteres);
                }

                return texto.ToUpper();

            }
            catch (Exception ex)
            {
                throw new Exception("Se ha producido un error al intentar centrar el texto: " + ex.Message);
            }
        }

        public static string Centrar(string texto, int caracteres)
        {
            int cespacios = 0;

            try
            {
                texto = texto.Trim();

                if (texto.Length > caracteres)
                {
                    texto = texto.Substring(0, caracteres);
                }
                else
                {
                    cespacios = (caracteres - texto.Length) / 2;
                }

                String strespacios = new String(' ', cespacios);
                texto = strespacios + texto + strespacios;

                return texto.ToUpper();

            }
            catch (Exception ex)
            {
                throw new Exception("Se ha producido un error al intentar centrar el texto: " + ex.Message);
            }
        }

        public static string Centrar(string textoIzq, string textoDer, int caracteres)
        {
            int cespacios = 0;
            int cartemp = 0;
            string texto = "";

            try
            {
                textoIzq = textoIzq.Trim();
                textoDer = textoDer.Trim();

                if ((textoIzq.Length + textoDer.Length) > caracteres)
                {
                    cartemp = (textoIzq.Length + textoDer.Length) - caracteres;

                    textoIzq = textoIzq.Substring(0, cartemp);
                    textoDer = textoDer.Substring(0, cartemp);
                }
                else
                {
                    cespacios = (caracteres - (textoIzq.Length + textoDer.Length));
                }

                String strespacios = new String(' ', cespacios);
                texto = textoIzq + strespacios + textoDer;

                return texto.ToUpper();

            }
            catch (Exception ex)
            {
                throw new Exception("Se ha producido un error al intentar centrar el texto: " + ex.Message);
            }
        }

        public static string Izquierda(string texto, int caracteres)
        {
            int cespacios = 0;

            try
            {
                texto = texto.Trim();

                if (texto.Length > caracteres)
                {
                    texto = texto.Substring(0, caracteres);
                }
                else
                {
                    cespacios = (caracteres - texto.Length);
                }

                String strespacios = new String(' ', cespacios);
                texto = texto + strespacios;

                return texto.ToUpper();

            }
            catch (Exception ex)
            {
                throw new Exception("Se ha producido un error al intentar colocar a la izquierda el texto: " + ex.Message);
            }
        }

        public static string Derecha(string texto, int caracteres)
        {
            int cespacios = 0;

            try
            {
                texto = texto.Trim();

                if (texto.Length > caracteres)
                {
                    texto = texto.Substring(0, caracteres);
                }
                else
                {
                    cespacios = (caracteres - texto.Length);
                }

                String strespacios = new String(' ', cespacios);
                texto = strespacios + texto;

                return texto.ToUpper();

            }
            catch (Exception ex)
            {
                throw new Exception("Se ha producido un error al intentar colocar a la derecha el texto: " + ex.Message);
            }
        }

        public static string Repetir(char caracter, int caracteres)
        {
            try
            {
                return new string(caracter, caracteres);

            }
            catch (Exception ex)
            {
                throw new Exception("Se ha producido un error al intentar centrar el texto: " + ex.Message);
            }
        }

        public static string EncabDetalle(string cantidad, string descrip, string total, int caracteres)
        {
            try
            {
                if (cantidad.Length > 6)
                {
                    cantidad = cantidad.Substring(0, 6);
                }
                else
                {
                    cantidad = new string(' ', (6 - cantidad.Length)) + cantidad;
                }


                if (total.Length > 8)
                {
                    total = total.Substring(0, 8);
                }
                else
                {
                    total = new string(' ', (8 - total.Length)) + total;
                }

                if (descrip.Length > (caracteres - 16))
                {
                    descrip = descrip.Substring(0, caracteres - 16);
                }
                else
                {
                    descrip = new string(' ', (caracteres - (descrip.Length + 16)) / 2) + descrip + new string(' ', (caracteres - (descrip.Length + 16)) / 2);
                }

                return cantidad + " " + descrip + " " + total;

            }
            catch (Exception e)
            {
                throw new Exception("Se ha producido un error al intentar generar el detalle del texto: " + e.Message);
            }
        }

        public static string Detalle(string cantidad, string descrip, string total, int caracteres)
        {
            try
            {
                cantidad = string.Format("{0:n2}", decimal.Parse(cantidad));

                if (cantidad.Length > 6)
                {
                    cantidad = new string('*', 6);
                }
                else
                {
                    cantidad = new string(' ', 6 - cantidad.Length) + cantidad;
                }


                total = string.Format("{0:n2}", decimal.Parse(total));

                if (total.Length > 7)
                {
                    total = new string('*', 7);
                }
                else
                {
                    total = new string(' ', 7 - total.Length) + total;
                }

                if (descrip.Length > (caracteres - 15))
                {
                    descrip = descrip.Substring(0, caracteres - 15);
                }
                else
                {
                    descrip = descrip + new string(' ', (caracteres - 15) - descrip.Length);
                }

                return cantidad + " " + descrip + " " + total;

            }
            catch (Exception e)
            {
                throw new Exception("Se ha producido un error al intentar generar el detalle del texto: " + e.Message);
            }
        }
    }
}
