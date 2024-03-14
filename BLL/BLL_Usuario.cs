using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Usuario
    {
        DAL_Usuario dalUsuario = new DAL_Usuario();

        public string Insertar_USUARIO(Usuario usuario)
        {
            try
            {
                dalUsuario.Insertar_Usuario( usuario);
                return "Su perfil fue creado exitosamente, por favor intente ingrear a la aplicación"; 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario Login_USUARIO(string correo, string contrasenia)
        {
            return dalUsuario.Login_USUARIO(correo, contrasenia);
        }

        public string Editar_USUARIO(Usuario usuario)
        {
            try
            {
                dalUsuario.Editar_USUARIO(usuario);
                Login_USUARIO(usuario.CorreoElectronico, usuario.Contrasenia);
                return "Su perfil fue actualizado";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string Recuperar_CONTRASENIA (string usuarioSolicitado)
        {
            return dalUsuario.Recuperar_CONTRASENIA(usuarioSolicitado);
        }

        public List<Usuario> Mostrar_USUARIO()
        {
            return dalUsuario.Mostrar_USUARIO();
        }

        public string Elimnar_USUARIO(int id)
        {
            dalUsuario.Eliminar_USUARIO(id);
            return "A partir de ahora la cuenta esta inactiva";
        }

        public string Activar_USUARIO(int id/*, string estado*/)
        {
            dalUsuario.Activar_USUARIO(id/*, estado*/);
            return "La cuenta de este usuario esta activa otra vez";
        }
  
        public List<Usuario> buscarGuardaParque()
        {
            return dalUsuario.buscarGuardaParque();
        }

        public string EnviarArchivos()
        {
            return dalUsuario.EnviarArchivos();
        }





    }
}
