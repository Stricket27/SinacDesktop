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
    public class DAL_OrdenDeCompra : ConexionASQL
    {
        public void Insertar_ORDEN_COMPRA (DateTime fechaOrden, int IDUsuario, int IDAreaConservacion)
        {
            try
            {
                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Insertar_ORDEN_COMPRA";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        //command.Parameters.AddWithValue("@NumeroOrden", disponibilidad.NumeroOrden);
                        command.Parameters.AddWithValue("@Fecha", fechaOrden);
                        command.Parameters.AddWithValue("@IDCliente", IDUsuario);
                        command.Parameters.AddWithValue("@IDArea", IDAreaConservacion);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public OrdenDeCompra SeleccionarNumeroOrden()
        {
            try
            {
                OrdenDeCompra ordenDeCompra = null;

                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "SELECT TOP (1) NumeroDeOrden from OrdenDeCompra order by NumeroDeOrden desc";
                        command.CommandType = System.Data.CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ordenDeCompra = new OrdenDeCompra();
                                ordenDeCompra.NumeroOrdenes = reader.GetInt32(0);
                            }

                            Cache.NumeroOrden = ordenDeCompra.NumeroOrdenes;
                        }
                    }
                }
                return ordenDeCompra;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool Fichar_ORDEN(string numeroOrden)
        {
            bool existe = false;
            try
            {
                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Ficha_ORDEN_COMPRA";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NumOrden", numeroOrden);
                        command.ExecuteReader();

                        existe = true;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return existe;
        }

    }
}
