using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BLL
{
    public class BLL_Disponibilidad
    {
        DAL_Disponibilidad dAL_Disponibilidad = new DAL_Disponibilidad();

        public string Insertar_DISPONIBILIDAD(Disponibilidad disponibilidad)
        {
            try
            {
                dAL_Disponibilidad.Insertar_Disponibilidad(disponibilidad);
                return "La disponibilidad se a crear correctamente";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string Editar_DISPONIBILIDAD(Disponibilidad disponibilidad)
        {
            dAL_Disponibilidad.Editar_DISPONIBILIDAD(disponibilidad);
            return "La disponibilidad fue editado";
        }
        public List<Disponibilidad> Mostrar_DISPONIBILIDAD()
        {
            return dAL_Disponibilidad.Mostrar_DISPONIBILIDAD();
        }
        public string Eliminar_Disponibilidad(int id)
        {
            dAL_Disponibilidad.Eliminar_DISPONIBILIDAD(id);
            return "Esta disponibilidad fue eliminado";
        }

        public string Actualizar_STOCK (int id, int cantidad)
        {
            dAL_Disponibilidad.Actualizar_STOCK(id, cantidad);
            return "";
        }


    }
}
