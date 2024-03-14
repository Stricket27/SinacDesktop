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
    public class DAL_Pago : ConexionASQL
    {

        public void Insertar_Pago(DateTime FechaPago, float montoTotal, Moneda moneda, int IDOrden)
        {
            try
            {
                using(var conexion = GetSqlConnection())
            {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Insertar_PAGO";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FechaDePAGO", FechaPago);
                        if (moneda == Moneda.Colones)
                        {
                            command.Parameters.AddWithValue("@MontoTotal", montoTotal);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@MontoTotal", montoTotal);
                        }
                        command.Parameters.AddWithValue("@Moneda", moneda.ToString());
                        command.Parameters.AddWithValue("@IDOrden", IDOrden);

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
