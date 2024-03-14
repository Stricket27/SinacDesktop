using AccesoADatos.SQLServer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LineaDeDetalle : ConexionASQL
    {

        public void Insertar_ORDEN_COMPRA(int IDDisponibilidad, int CantidadEntradas, int IDOrden,
        string NCVisitante1,
        string NCVisitante2,
        string IVisitante1,
        string IVisitante2,
        PaisResidencia PRVisitante1,
        PaisResidencia PRVisitante2)
        {
            try
            {
                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Insertar_LINEA_DETALLE";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        
                        command.Parameters.AddWithValue("@Cantidad", CantidadEntradas);
                        command.Parameters.AddWithValue("@IDDisponibilidad", IDDisponibilidad);
                        command.Parameters.AddWithValue("@IDOrden", IDOrden);
                        command.Parameters.AddWithValue("@NCVisitante1", NCVisitante1);
                        command.Parameters.AddWithValue("@NCVisitante2", NCVisitante2);
                        command.Parameters.AddWithValue("@IVisitante1", IVisitante1);
                        command.Parameters.AddWithValue("@IVisitante2", IVisitante2);
                        command.Parameters.AddWithValue("@PRVisitante1", PRVisitante1.ToString());
                        command.Parameters.AddWithValue("@PRVisitante2", PRVisitante2.ToString());


                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



























    }
}
