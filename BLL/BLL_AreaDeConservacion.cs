using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_AreaDeConservacion
    {
        DAL_AreaDeConservacion dAL_Area = new DAL_AreaDeConservacion();
        
        public string Insertar_AREACONSERVACION(AreaConservacion area)
        {
            try
            {
                dAL_Area.Insetar_AREACONSERVACION(area);
                return "Se a creado el area de conservacion exitosamente";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string Editar_AREACONSERVACION(AreaConservacion area)
        {
            try
            {
                dAL_Area.Editar_AREACONSERVACION(area);
                return "El area de conservacion fue modificado";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<AreaConservacion> Mostrar_AREACONSERVACION()
        {
            return dAL_Area.Mostar_AREACONSERVACION();
        }

        public string Eliminar_AreaConservacion(int id)
        {
            dAL_Area.Eliminar_AREACONSERVACION(id);
            return "Esta area de conservacion esta eliminada";
        }

        
    }
}
