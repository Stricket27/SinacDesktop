using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_OrdenDeCompra
    {
        DAL_OrdenDeCompra dAL_Orden = new DAL_OrdenDeCompra();

        public string Insertar_ORDEN_COMPRA(DateTime fechaOrden, int IDUsuario, int IDAreaConservacion)
        {
            dAL_Orden.Insertar_ORDEN_COMPRA(fechaOrden, IDUsuario, IDAreaConservacion);
            return "";
        }

        public bool Fichar_ORDEN(string numeroOrden)
        {
            return dAL_Orden.Fichar_ORDEN(numeroOrden);
        }


        public OrdenDeCompra SeleccionarNumeroOrden()
        {
            return dAL_Orden.SeleccionarNumeroOrden();
        }

    }
}
