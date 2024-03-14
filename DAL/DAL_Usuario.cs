using AccesoADatos.SQLServer;
using AccesoADatos.Persistencia;
using AccesoADatos.ServicioEmail;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Usuario : ConexionASQL
    {

        public void Insertar_Usuario( Usuario usuario)
        {
            try
            {
                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Insertar_USUARIO";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        command.Parameters.AddWithValue("@Nacionalidad", usuario.Nacionalidad);
                        command.Parameters.AddWithValue("@FechaDeNacimiento", usuario.FechaDeNacimiento);
                        command.Parameters.AddWithValue("@Profesion", usuario.Profesion);
                        command.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);
                        command.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception )
            {

                throw;
            }
        }

        public Usuario Login_USUARIO(string correo, string contrasenia)
        {
            try
            {
                Usuario usuario = null;
                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Login_USUARIO";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CorreoElectronico", correo);
                        command.Parameters.AddWithValue("@Contrasenia", contrasenia);

                        SqlDataReader dataReader = command.ExecuteReader();

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                usuario = new Usuario();

                                usuario.ID = dataReader.GetInt32(0);
                                usuario.Nombre = dataReader.GetString(1);
                                usuario.Apellido = dataReader.GetString(2);
                                usuario.Telefono = dataReader.GetInt32(3);
                                usuario.Nacionalidad = dataReader.GetString(4);
                                usuario.FechaDeNacimiento = dataReader.GetString(5);
                                usuario.Profesion = dataReader.GetString(6);
                                usuario.CorreoElectronico = dataReader.GetString(7);
                                usuario.Contrasenia = dataReader.GetString(8);
                                usuario.Estado = dataReader.GetString(9);

                                Cache.ID = usuario.ID;
                                Cache.Nombre = usuario.Nombre;
                                Cache.Apellido = usuario.Apellido;
                                Cache.CorreoElectronico = usuario.CorreoElectronico;

                            }
                        }
                    }
                }
                return usuario;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Editar_USUARIO(Usuario usuario)
        {
            try
            {
                using (var conexion = GetSqlConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Editar_USUARIO";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        command.Parameters.AddWithValue("@Nacionalidad", usuario.Nacionalidad);
                        command.Parameters.AddWithValue("@FechaDeNacimiento", usuario.FechaDeNacimiento);
                        command.Parameters.AddWithValue("@Profesion", usuario.Profesion);
                        command.Parameters.AddWithValue("@Correo", usuario.CorreoElectronico);
                        command.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
                        command.Parameters.AddWithValue("@ID", usuario.ID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string Recuperar_CONTRASENIA (string UsuarioSolicitado)
        {
            using(var conexion = GetSqlConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = conexion;
                    command.CommandText = "Recuperar_CONTRASENIA";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CorreoElectronico", UsuarioSolicitado);

                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.Read() == true)
                    {
                        string nombreUsuario = dataReader.GetString(1) + " " + dataReader.GetString(2);
                        string correoUsuario = dataReader.GetString(7);
                        string contraseniaUsuario = dataReader.GetString(8);


                        var servicioCorreo = new AccesoADatos.ServicioEmail.AdministradorDelSistema();
                        servicioCorreo.EnviarEmail(
                            sujeto: "Sistema: Solicitar contraseña",
                            cuerpo: "Hola, " + nombreUsuario + "\nSolicitaste recuperar tu contraseña a la aplicación. \n" +
                            "La CONTRASEÑA solicitada es:  " + contraseniaUsuario +
                            "\nADVERTENCIA: Ten en cuenta que esta es su CONTRASEÑA, por favor CAMBIAR la dicha contraseña en ►EDITAR PERFIL◄ " +
                            "\nYa puedes ingresar a la aplicación, por favor intentar",
                            emailReciente: new List<string> { correoUsuario }
                            );
                        return "Hola, " + nombreUsuario + "\nSolicitaste recuperar tu contraseña a la aplicación. \n" +
                            "La CONTRASEÑA solicitada es:  " + contraseniaUsuario +
                            "\nADVERTENCIA: Ten en cuenta que esta es su CONTRASEÑA, por favor CAMBIAR la dicha contraseña en ►EDITAR PERFIL◄" +
                            "\nYa puedes ingresar a la aplicación, por favor intentar ingresar";
                    }
                    else
                    {
                        return "Lo sentimos, pero usted no esta ingresado, por favor registrarse a la aplicación primero";
                    }

                }
            }
        }

        public string EnviarArchivos()
        {
            using(var conexion = GetSqlConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = conexion;

                        var servicioCorreo = new AccesoADatos.ServicioEmail.AdministradorDelSistema();
                        servicioCorreo.EnviarArchivos(
                            sujeto: "Factura Electronica",
                            emailReciente: new List<string> { Cache.CorreoElectronico }
                            );
                }
            }
            return "Se envio a su correo la factura electronica";
        }



        public List<Usuario> Mostrar_USUARIO()
        {
            DataSet dataSet = null;
            List<Usuario> listaU = new List<Usuario>();
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.StoredProcedure;
            string sql = "Mostrar_USUARIO";
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
                        Usuario usuario = new Usuario();
                        usuario.ID = int.Parse(dataRow["Codigo"].ToString());
                        usuario.Nombre = dataRow["Nombre"].ToString();
                        usuario.Apellido = dataRow["Apellido"].ToString();
                        usuario.Telefono = int.Parse(dataRow["Telefono"].ToString());
                        usuario.Nacionalidad = dataRow["Nacionalidad"].ToString();
                        usuario.FechaDeNacimiento = dataRow["Fecha de nacimiento"].ToString();
                        usuario.Profesion = dataRow["Profesion"].ToString();
                        usuario.CorreoElectronico = dataRow["CorreoElectronico"].ToString();
                        usuario.Contrasenia = dataRow["Contraseña"].ToString();
                        usuario.Estado = dataRow["Estado"].ToString();

                        listaU.Add(usuario);

                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return listaU;
        }

        public bool Eliminar_USUARIO( int id)
        {
            double rows = 0d;
            string sql = "Eliminar_USUARIO";
            SqlCommand command = new SqlCommand();
            try
            {
                command.Parameters.AddWithValue("@Id", id);
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
            return rows > 0;
        }

        public bool Activar_USUARIO(int id)
        {
            double rows = 0d;
            string sql = "Activar_USUARIO";
            SqlCommand command = new SqlCommand();
            try
            {
                command.Parameters.AddWithValue("@Id", id);

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
            return rows > 0;
        }

        public List<Usuario> buscarGuardaParque()
        {
            DataSet dataSet = null;
            List<Usuario> listaU = new List<Usuario>();
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.StoredProcedure;
            string sql = "BuscarGuardaParque";
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
                        Usuario usuario = new Usuario();
                        usuario.ID = int.Parse(dataRow["Codigo"].ToString());
                        usuario.Nombre = dataRow["Nombre"].ToString();
                        usuario.Apellido = dataRow["Apellido"].ToString();
                        usuario.Telefono = int.Parse(dataRow["Telefono"].ToString());
                        usuario.Nacionalidad = dataRow["Nacionalidad"].ToString();
                        usuario.FechaDeNacimiento = dataRow["Fecha de nacimiento"].ToString();
                        usuario.Profesion = dataRow["Profesion"].ToString();
                        usuario.CorreoElectronico = dataRow["CorreoElectronico"].ToString();
                        usuario.Contrasenia = dataRow["Contraseña"].ToString();
                        usuario.Estado = dataRow["Estado"].ToString();

                        listaU.Add(usuario);

                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return listaU;
        }





























    }
}
