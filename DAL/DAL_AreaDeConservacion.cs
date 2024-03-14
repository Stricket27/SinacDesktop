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
    public class DAL_AreaDeConservacion : ConexionASQL
    {

        public void Insetar_AREACONSERVACION(AreaConservacion pArea)
        {
            try
            {
                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Insetar_AREACONSERVACION";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Codigo", pArea.Codigo);
                        command.Parameters.AddWithValue("@Nombre", pArea.Nombre);
                        command.Parameters.AddWithValue("@Fotografia", pArea.Fotografia);
                        command.Parameters.AddWithValue("@SitioWeb", pArea.SitioWeb);
                        command.Parameters.AddWithValue("@TipoDeArea", pArea.TipoArea);
                        command.Parameters.AddWithValue("@IDUsuario", pArea.IdUsuario);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Editar_AREACONSERVACION (AreaConservacion pArea)
        {
            try
            {
                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Editar_AREACONSERVACION";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Codigo", pArea.Codigo);
                        command.Parameters.AddWithValue("@Nombre", pArea.Nombre);
                        command.Parameters.AddWithValue("@Fotografia", pArea.Fotografia);
                        command.Parameters.AddWithValue("@SitioWeb", pArea.SitioWeb);
                        command.Parameters.AddWithValue("@TipoDeArea", pArea.TipoArea);
                        command.Parameters.AddWithValue("@IDUsuario", pArea.IdUsuario);
                        command.Parameters.AddWithValue("@ID", pArea.ID);

                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
             
        }

        public List<AreaConservacion> Mostar_AREACONSERVACION()
        {

            DataSet dataSet = null;
            List<AreaConservacion> listaAC = new List<AreaConservacion>();
            SqlCommand command = new SqlCommand();

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = @"[Mostrar_AREACONSERVACION]";

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    dataSet = db.ExecuteReader(command, "query");
                }
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    {

                        AreaConservacion area = new AreaConservacion()
                        {
                            ID = int.Parse(dataRow["ID"].ToString()),
                            Codigo = dataRow["Codigo"].ToString(),
                            Nombre = dataRow["Nombre"].ToString(),
                            Fotografia = (byte[])dataRow["Fotografia"],
                            SitioWeb = dataRow["SitioWeb"].ToString(),
                            TipoArea = dataRow["TipoDeArea"].ToString(),
                            IdUsuario = int.Parse(dataRow["IDUsuario"].ToString())

                        };
                        Cache.IDArea = area.ID;
                        listaAC.Add(area);

                    }
                }
                return listaAC;
            }
            catch (Exception)
            {

                throw;
            }
            //return listaAC;
        }

        public bool Eliminar_AREACONSERVACION(int id)
        {
            double rows = 0d;
            string sql = "Eliminar_AREACONSERVACION";
            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@ID", id);
                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }
                return rows > 0;


            }
            catch (Exception)
            {

                throw;
            }
            //return rows > 0;
        }

        public AreaConservacion GetAreaConservacionById(int pId)
        {
            DataSet dataSet = null;
            AreaConservacion oArea = null;
            string sql = @"Select * from AreaDeConservacion where ID = @ID";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@ID", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    dataSet = db.ExecuteReader(command, "query");
                }
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    DataRow dataRow = dataSet.Tables[0].Rows[0];
                    oArea = new AreaConservacion()
                    {
                        ID = int.Parse(dataRow["ID"].ToString()),
                        Codigo = dataRow["Codigo"].ToString(),
                        Nombre = dataRow["Nombre"].ToString(),
                        Fotografia = (byte[])dataRow["Fotografia"],
                        SitioWeb = dataRow["SitioWeb"].ToString(),
                        TipoArea = dataRow["TipoDeArea"].ToString(),
                        IdUsuario = int.Parse(dataRow["IDUsuario"].ToString())
                    };
            }
                return oArea;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public AreaConservacion Buscar_AREA_USUARIO(int ID)
        {
            DataSet dataSet = null;
            AreaConservacion oArea = null;
            //Usuario oUsuario = null;
            string sql = @"[Buscar_AREA_USUARIO]";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@IDUsuario", ID);
                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    dataSet = db.ExecuteReader(command, "query");
                }
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    DataRow dataRow = dataSet.Tables[0].Rows[0];
                    oArea = new AreaConservacion();
                    //oUsuario = new Usuario();

                    oArea.ID = int.Parse(dataRow["ID"].ToString());
                    oArea.Codigo = dataRow["Codigo"].ToString();
                    oArea.Nombre = dataRow["Nombre"].ToString();
                    oArea.Fotografia = (byte[])dataRow["Fotografia"];
                    oArea.SitioWeb = dataRow["SitioWeb"].ToString();
                    oArea.TipoArea = dataRow["TipoDeArea"].ToString();
                    oArea.IdUsuario = int.Parse(dataRow["IDUsuario"].ToString());
                    //oUsuario.Nombre = dataRow["Nombre"].ToString();
                    //oUsuario.Apellido = dataRow["Apellido"].ToString();
                    
                }
                return oArea;
            }
            catch (Exception)
            {

                throw;
            }



        }




    }
}
