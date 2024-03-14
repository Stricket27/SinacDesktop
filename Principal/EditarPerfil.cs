using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.SINAC
{
    public partial class EditarPerfil : UserControl
    {
        public Usuario usuario { get; set; }
        public EditarPerfil()
        {
            InitializeComponent();
        }

        private void EditarPerfil_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {

            labelNombre.Text = usuario.Nombre;
            labelApellido.Text = usuario.Apellido;
            labelTelefono.Text = usuario.Telefono.ToString();
            labelNacionalidad.Text = usuario.Nacionalidad;
            labelFechaDeNacimiento.Text = usuario.FechaDeNacimiento;
            labelCorreoElectronico.Text = usuario.CorreoElectronico;
            labelProfesion.Text = usuario.Profesion;

            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtTelefono.Text = usuario.Telefono.ToString();
            txtNacionalidad.Text = usuario.Nacionalidad;
            mtbFechaDeNacimiento.Text = usuario.FechaDeNacimiento;
            txtProfesion.Text = usuario.Profesion;
            txtCorreoElectronico.Text = usuario.CorreoElectronico;
            txtContrasenia.Text = usuario.Contrasenia;
            txtConfirmarContrasenia.Text = usuario.Contrasenia;
        }

        private void InicializarControlesEdicionContrasenia()
        {
            LinkEditar.Text = "Editar";
            txtContrasenia.Enabled = false;
            txtContrasenia.UseSystemPasswordChar = true;
            txtConfirmarContrasenia.Enabled = false;
            txtConfirmarContrasenia.UseSystemPasswordChar = true;
        }

        private void Reiniciar()
        {
            CargarDatos();
            InicializarControlesEdicionContrasenia();
        }
        private void HabilitarCampos()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtNacionalidad.Enabled = true;
            mtbFechaDeNacimiento.Enabled = true;
            txtContraseniaActual.Enabled = true;
            txtProfesion.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtNacionalidad.Enabled = false;
            mtbFechaDeNacimiento.Enabled = false;
            txtContraseniaActual.Enabled = false;
            txtProfesion.Enabled = false;
            txtContraseniaActual.Text = "";
        }


        private void LinkEditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HabilitarCampos();
        }

        private void LinkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkEditar.Text == "Editar")
            {
                LinkEditar.Text = "Cancelar";
                txtContrasenia.Enabled = true;
                txtContrasenia.Text = "";
                txtConfirmarContrasenia.Enabled = true;
                txtConfirmarContrasenia.Text = "";
            }
            else if (LinkEditar.Text == "Cancelar")
            {
                Reiniciar();
                InicializarControlesEdicionContrasenia();
                txtContrasenia.Text = usuario.Contrasenia;
                txtConfirmarContrasenia.Text = usuario.Contrasenia;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContrasenia.Text.Length >= 5)
                {
                    if (txtContrasenia.Text == txtConfirmarContrasenia.Text)
                    {
                        if (txtContraseniaActual.Text == usuario.Contrasenia)
                        {

                            usuario.ID = usuario.ID;
                            usuario.Nombre = txtNombre.Text;
                            usuario.Apellido = txtApellido.Text;
                            usuario.Telefono = int.Parse(txtTelefono.Text);
                            usuario.Nacionalidad = txtNacionalidad.Text;
                            usuario.FechaDeNacimiento = mtbFechaDeNacimiento.Text;
                            usuario.Profesion = txtProfesion.Text;
                            usuario.Contrasenia = txtContrasenia.Text;

                            var bll_usuario = new BLL_Usuario();
                            bll_usuario.Editar_USUARIO(usuario);
                            MessageBox.Show("Su perfil fue actualizado");
                            Reiniciar();
                            DeshabilitarCampos();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que ningun campo este vacio");
            }
            
        }








































    }
}
