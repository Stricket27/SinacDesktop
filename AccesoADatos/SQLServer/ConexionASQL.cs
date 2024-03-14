using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.SQLServer
{
    public abstract class ConexionASQL
    {

        private readonly string conexion;

        public ConexionASQL()
        {
            conexion = "Data Source=localhost;Initial Catalog=SINAC;User ID=sa;Password=123456";
        }

        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(conexion);
        }

       





    }
}
