﻿using LinkPosModelo;
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

        public List<string> CrearDocumento(long OrderID, string TipoDoc)
        {
            List<string> ls = new List<string>();

            try
            {
                #region Variables Modelo
                Tickets tck = contexdb.Get<Tickets>(x => x.TicketId == OrderID);
                QuickServeCustomers quickServeCustomers = contexdb.Get<QuickServeCustomers>(x => x.TicketId == tck.TicketId);
                CustomerDetails customerDetails = contexdb.Get<CustomerDetails>(x => x.CustomerID == tck.CustomerDetailsId);
                OrderTypes tipoOrden = contexdb.Get<OrderTypes>(x => x.OrderTypeId == tck.OrderTypeId);
                SeatingChartDetails mesa = contexdb.Get<SeatingChartDetails>(x => x.SeatingChartId == tck.SeatingChartId);
                List<TicketDetails> detaOrden = contexdb.GetAll<TicketDetails>(x => x.TicketID == tck.TicketId && x.ItemStatusId != 3 && x.Price != 0).OrderBy(x => x.TicketDetailsId).ToList();
                var detalle = detaOrden.GroupBy(x => x.ItemName)
                    .Select(g => new 
                    {
                        DetaID = g.Key,
                        Cantidad = g.Sum(y => y.Quantity),
                        Producto = g.Key,
                        Total = g.Sum(y=> y.Quantity*y.Price)

                    });
                #endregion

                ls.Add(Texto.Centrar(Config.Obtener.NomComer, Config.Obtener.CantCar_Tck));
                ls.Add("");
                ls.Add(Texto.Centrar(Config.Obtener.NomEmpre, Config.Obtener.CantCar_Tck));
                foreach (string s in Config.Obtener.Encabezado)
                {
                    ls.Add(Texto.Centrar(s, Config.Obtener.CantCar_Tck));
                }
                ls.Add(Texto.Centrar("GIRO: " + Config.Obtener.Giro, Config.Obtener.CantCar_Tck));
                ls.Add(Texto.Centrar("CAJA: " + 0, Config.Obtener.CantCar_Tck));
                ls.Add("");
                ls.Add(Texto.Centrar("RES. Nº: ", "0", Config.Obtener.CantCar_Tck));
                ls.Add(Texto.Centrar("FECHA RESOL.: ", "0", Config.Obtener.CantCar_Tck));
                ls.Add(Texto.Centrar("SERIE: ", "0", Config.Obtener.CantCar_Tck));
                ls.Add(Texto.Centrar("RANGO : ", "0", Config.Obtener.CantCar_Tck));
                ls.Add(Texto.Centrar(" ", Config.Obtener.CantCar_Tck));


                ls.Add(Texto.Centrar("ATENDIO: " + tck.Users.FirstName + " " + tck.Users.LastName, "ESTACIÓN: " + tck.TerminalId, Config.Obtener.CantCar_Tck));
                ls.Add(Texto.Repetir('*', Config.Obtener.CantCar_Tck));
                ls.Add(Texto.Centrar("TICKET Nº : " + 0, "ESTACIÓN: " + tipoOrden.OrderType, Config.Obtener.CantCar_Tck));
                if (mesa != null)
                {
                    ls.Add(Texto.Centrar("MESA : " + mesa.TableCaption, "PERSONAS: " + tck.Guests, Config.Obtener.CantCar_Tck));
                }
                ls.Add(Texto.Repetir('*', Config.Obtener.CantCar_Tck));
                ls.Add(Texto.EncabDetalle("CNT", "PRODUCTO", "TOTAL", Config.Obtener.CantCar_Tck));
                ls.Add(Texto.Repetir('.', Config.Obtener.CantCar_Tck));

                foreach(var d in detalle)
                {

                    ls.Add(Texto.Detalle(d.Cantidad.ToString(), d.Producto,d.Total.ToString(), Config.Obtener.CantCar_Tck));
                }

                ls.Add(Texto.Repetir('.', Config.Obtener.CantCar_Tck));
                ls.Add(Texto.Centrar("TOTAL VENTAS:", tck.Subtotal.ToString(), Config.Obtener.CantCar_Tck));



                return ls;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ImprimirDocumento(long OrderID, string TipoDoc)
        {
            bool bandera = false;
            PosImpresor print = new PosImpresor();

            try
            {
                print.Imprimir(CrearDocumento(OrderID, TipoDoc), TipoDoc);
                return bandera;
            }
            catch (Exception e)
            {
                throw new Exception("Se ha generado el siguente error al intentar imprimir el documento: " + e.Message);
            }

        }
    }
}
