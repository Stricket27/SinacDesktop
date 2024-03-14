using AccesoADatos.Persistencia;
using AccesoADatos.SQLServer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Disponibilidad : ConexionASQL
    {

        public void Insertar_Disponibilidad(Disponibilidad disponibilidad)
        {
            try
            {
                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Insertar_DISPONIBILIDAD";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IDAreaDeConservacion", disponibilidad.IDAreaConservacion);
                        command.Parameters.AddWithValue("@HoraDeInicio", disponibilidad.HoraDeInicio);
                        command.Parameters.AddWithValue("@HoraFinal", disponibilidad.HoraFinal);
                        command.Parameters.AddWithValue("@CantidadDeEntradas", disponibilidad.CantidadEntradas);
                        command.Parameters.AddWithValue("@Precio", disponibilidad.Precio);

                        command.Parameters.AddWithValue("@FechaDeReservacion", disponibilidad.FechaDeReservacion);

                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Editar_DISPONIBILIDAD(Disponibilidad disponibilidad)
        {
            try
            {
                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Editar_DISPONIBILIDAD";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IDAreaDeConservacion", disponibilidad.IDAreaConservacion);
                        command.Parameters.AddWithValue("@HoraDeInicio", disponibilidad.HoraDeInicio);
                        command.Parameters.AddWithValue("@HoraFinal", disponibilidad.HoraFinal);
                        command.Parameters.AddWithValue("@CantidadDeEntradas", disponibilidad.CantidadEntradas);
                        command.Parameters.AddWithValue("@Precio", disponibilidad.Precio);
                        command.Parameters.AddWithValue("@ID", disponibilidad.ID);

                        command.Parameters.AddWithValue("@FechaDeReservacion", disponibilidad.FechaDeReservacion);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


            
        }

        public bool Eliminar_DISPONIBILIDAD(int id)
        {
            double rows = 0d;
            string sql = "Eliminar_DISPONIBILIDAD";
            SqlCommand command = new SqlCommand();
            
            try
            {
                command.Parameters.AddWithValue("@ID", id);
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = db.ExecuteNonQuery(command, System.Data.IsolationLevel.ReadCommitted);
                }
                return rows > 0;

            }
            catch (Exception)
            {

                throw;
            }
            return rows > 0;
        }

        public List<Disponibilidad> Mostrar_DISPONIBILIDAD()
        {
            DataSet dataSet = null;
            List<Disponibilidad> listaDTO = new List<Disponibilidad>();
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.StoredProcedure;
            string sql = "Mostar_DISPONIBILIDAD_AREA";
            command.CommandText = sql;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    dataSet = db.ExecuteReader(command, "query");
                }
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    {
                        
                        Disponibilidad DTO = new Disponibilidad();

                        DTO.ID = int.Parse(dataRow["Codigo"].ToString());
                        DTO.IDAreaConservacion = int.Parse(dataRow["Numero de area/parque"].ToString());
                        DTO.HoraDeInicio = dataRow["Horario de inicio"].ToString();
                        DTO.HoraFinal = dataRow["Horario final"].ToString();
                        DTO.CantidadEntradas = int.Parse(dataRow["Cantidad de entradas"].ToString());
                        DTO.Precio = float.Parse(dataRow["Precio"].ToString());
                        DTO.FechaDeReservacion = DateTime.Parse(dataRow["Fecha de reservacion"].ToString());

                        listaDTO.Add(DTO);
                    }
                }
                return listaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Actualizar_STOCK(int id, int cantidadEntradas)
        {
            using (var conexion = GetSqlConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Actualizar_STOCK";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@CantidadEntradas", cantidadEntradas);

                    command.ExecuteNonQuery();

                }
            }
        }





























    }
}
