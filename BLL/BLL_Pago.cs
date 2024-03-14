using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Pago
    {
        DAL_Pago dAL_Pago = new DAL_Pago();
        public string Insertar_Pago(DateTime FechaPago, float montoTotal, Moneda moneda, int IDOrden)
        {
            dAL_Pago.Insertar_Pago(FechaPago, montoTotal, moneda,IDOrden);
            return "";
        }



    }
}
