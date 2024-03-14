using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_LineaDeDetalle
    {
        DAL_LineaDeDetalle dAL_Linea = new DAL_LineaDeDetalle();
        public string Insertar_LINEA_DETALLE(int IDDisponibilidad, int CantidadEntradas, int IDOrden,
            string NCVisitante1,
        string NCVisitante2,
        string IVisitante1,
        string IVisitante2,
        PaisResidencia PRVisitante1,
        PaisResidencia PRVisitante2)
        {
            dAL_Linea.Insertar_ORDEN_COMPRA(CantidadEntradas, IDDisponibilidad, IDOrden,NCVisitante1,
        NCVisitante2,
        IVisitante1,
        IVisitante2,
        PRVisitante1,
        PRVisitante2);
            return "Insertado";
        }


    }
}
