using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Persistencia
{
    public class FactoryConexion
    {
        public static string CreateConnection()
        {
            StringBuilder conexion = new StringBuilder();
            // Lee la conexion default
            conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["Proyecto.SINAC.Properties.Settings.ConexionSINAC"].ConnectionString);

            return conexion.ToString();
        }

    }
}
