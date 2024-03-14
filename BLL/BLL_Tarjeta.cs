using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Tarjeta
    {
        DAL_Tarjeta dAL_Tarjeta = new DAL_Tarjeta();

        public string Insertar_TARJETA (Tarjeta tarjeta/*, Usuario usuario*/)
        {
            try
            {
                dAL_Tarjeta.Insertar_TARJETA(tarjeta/*, usuario*/);
                return "Su tarjeta a sido aceptada";
            }
            catch (Exception)
            {

                throw;
            }
            
        }


    }
}
