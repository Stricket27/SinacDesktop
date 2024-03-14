using BLL;
using Entities;
using Proyecto.SINAC.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.SINAC
{
    public partial class RegistrarU : Form
    {
        Usuario usuario = new Usuario();
        public RegistrarU()
        {
            InitializeComponent();
        }
        #region from
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContrasenia.Text.Length >= 5)
                {
                    if (txtContrasenia.Text == txtConfirmarContrasenia.Text)
                    {

                        usuario.ID = usuario.ID;
                        usuario.Nombre = txtNombre.Text;
                        usuario.Apellido = txtApellido.Text;
                        usuario.Telefono = int.Parse(txtTelefono.Text);
                        usuario.Nacionalidad = txtNacionalidad.Text;
                        usuario.FechaDeNacimiento = mtbFechaDeNacimiento.Text;
                        usuario.Profesion = txtProfesion.Text;
                        usuario.CorreoElectronico = txtCorreoElectronico.Text;
                        usuario.Contrasenia = txtContrasenia.Text;

                        var bll_usuario = new BLL_Usuario();
                        var resultado = bll_usuario.Insertar_USUARIO(usuario);
                        MessageBox.Show(resultado);                    }
                    else
                    {
                        MessageBox.Show("Por favor revisar los datos requeridos");
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña debe de ser minimo de 5 caracteres");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que ningun campo este vacio");
            }
            LimpiarDatos();
        }
        

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            IdiomaEspanol();
        }

        private void LimpiarDatos()
        {
            txtNombre.Text = "" ;
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtNacionalidad.Text = "";
            mtbFechaDeNacimiento.Text = "";
            txtProfesion.Text = "";
            txtCorreoElectronico.Text = "";
            txtContrasenia.Text = "" ;
            txtConfirmarContrasenia.Text = "";
        }

        private void IdiomaEspanol()
        {
            label1.Text = ResRegistrarse.Nombre;
            label2.Text = ResRegistrarse.Apellido;
            label3.Text = ResRegistrarse.NumeroTelefono;
            label4.Text = ResRegistrarse.Nacionalidad;
            label5.Text = ResRegistrarse.FechaNacimiento;
            label6.Text = ResRegistrarse.Profesion;
            label7.Text = ResRegistrarse.CorreoElectronico;
            label8.Text = ResRegistrarse.Contrasenia;
            label9.Text = ResRegistrarse.ConfirmarContrasenia;
            label10.Text = ResRegistrarse.CrearUsuario;
            label17.Text = ResRegistrarse.IngreseDatosPersonales;
            btnRegistarse.Text = ResRegistrarse.Registrarse;
        }

        private void IdiomaIngles()
        {
            label1.Text = ResRegistrarse_en_USA.Nombre;
            label2.Text = ResRegistrarse_en_USA.Apellido;
            label3.Text = ResRegistrarse_en_USA.NumeroTelefono;
            label4.Text = ResRegistrarse_en_USA.Nacionalidad;
            label5.Text = ResRegistrarse_en_USA.FechaNacimiento;
            label6.Text = ResRegistrarse_en_USA.Profesion;
            label7.Text = ResRegistrarse_en_USA.CorreoElectronico;
            label8.Text = ResRegistrarse_en_USA.Contrasenia;
            label9.Text = ResRegistrarse_en_USA.ConfirmarContrasenia;
            label10.Text = ResRegistrarse_en_USA.CrearUsuario;
            label17.Text = ResRegistrarse_en_USA.IngreseDatosPersonales;
            btnRegistarse.Text = ResRegistrarse_en_USA.Registrarse;
        }


        private void rdbEspanol_CheckedChanged(object sender, EventArgs e)
        {
            IdiomaEspanol();
        }

        private void rdbIngles_CheckedChanged(object sender, EventArgs e)
        {
            IdiomaIngles();
        }
    }
}
