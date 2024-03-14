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
    public class DAL_Tarjeta : ConexionASQL
    {

        public void Insertar_TARJETA(Tarjeta tarjeta /*, Usuario usuario*/)
        {
            try
            {
                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Insertar_TARJETA";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@NumeroDeTarjeta", tarjeta.Numero);
                        command.Parameters.AddWithValue("@MesDeVencimiento", tarjeta.MesDeVencimiento);
                        command.Parameters.AddWithValue("@AnioDeVencimiento", tarjeta.AnioDeVencimiento);
                        command.Parameters.AddWithValue("@CodigoDeSeguridad", tarjeta.Codigo);
                        command.Parameters.AddWithValue("@TipoDeTarjeta", tarjeta.tipo);
                        //command.Parameters.AddWithValue("@IDUsuario", tarjeta.IDUsuario);

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
