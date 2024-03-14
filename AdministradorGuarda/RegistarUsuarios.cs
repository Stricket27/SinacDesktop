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
    public partial class RegistarUsuarios : UserControl
    {
        //public Usuario usuario { get; set; }
        Usuario usuario = new Usuario();
        public RegistarUsuarios()
        {
            InitializeComponent();
        }

        private void RegistarUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuario();
        }
        private void MostrarUsuario()
        {
            var bll_Usuario = new BLL_Usuario();
            dgvListaDeUsuarios.DataSource = bll_Usuario.Mostrar_USUARIO();
        }

        private void dgvListaDeUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvListaDeUsuarios.SelectedRows.Count > 0)
                {
                    var usuario = (Usuario)dgvListaDeUsuarios.SelectedRows[0].DataBoundItem;
                    txtNombre.Text = usuario.Nombre;
                    txtApellido.Text = usuario.Apellido;
                    txtTelefono.Text = usuario.Telefono.ToString();
                    txtNacionalidad.Text = usuario.Nacionalidad;
                    mtbFechaDeNacimiento.Text = usuario.FechaDeNacimiento;
                    txtProfesion.Text = usuario.Profesion;
                    txtCorreoElectronico.Text = usuario.CorreoElectronico;
                    txtContrasenia.Text = usuario.Contrasenia;
                    txtConfirmarContrasenia.Text = usuario.Contrasenia;

                    txtCorreoElectronico.Enabled = false;
                    txtContrasenia.Enabled = false;
                    txtConfirmarContrasenia.Enabled = false;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarPanel()
        {
            panel2.Visible = true;
        }

        private void linkLabelCrearModificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelCrearModificar.Text == "Crear / Modificar Usuario")
            {
                linkLabelCrearModificar.Text = "Ocultar panel";
                MostrarPanel();
            }
            else if(linkLabelCrearModificar.Text == "Ocultar panel")
            {
                linkLabelCrearModificar.Text = "Crear / Modificar Usuario";
                panel2.Visible = false;
            }
        }

        private void LimpiarDatos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtNacionalidad.Text = "";
            mtbFechaDeNacimiento.Text = "";
            txtProfesion.Text = "";
            txtCorreoElectronico.Text = "";
            txtContrasenia.Text = "";
            txtConfirmarContrasenia.Text = "";
        }

        private void tsbRegistrar_Click(object sender, EventArgs e)
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
                        MessageBox.Show(resultado);
                        MostrarUsuario();
                        LimpiarDatos();
                    }
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

            
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListaDeUsuarios.SelectedRows.Count > 0)
                {
                    if (txtContrasenia.Text.Length >= 5)
                    {
                        if (txtContrasenia.Text == txtConfirmarContrasenia.Text)
                        {
                            usuario = dgvListaDeUsuarios.SelectedRows[0].DataBoundItem as Usuario;

                            usuario.ID = usuario.ID;
                            usuario.Nombre = txtNombre.Text;
                            usuario.Apellido = txtApellido.Text;
                            usuario.Telefono = int.Parse(txtTelefono.Text);
                            usuario.Nacionalidad = txtNacionalidad.Text;
                            usuario.FechaDeNacimiento = mtbFechaDeNacimiento.Text;
                            usuario.Profesion = txtProfesion.Text;
                            usuario.CorreoElectronico = txtCorreoElectronico.Text;
                            usuario.Contrasenia = txtContrasenia.Text;

                        var bll_Usuario = new BLL_Usuario();
                            var resultado = bll_Usuario.Editar_USUARIO(usuario);
                            MessageBox.Show("El perfil fue actualizado");
                            MostrarUsuario();
                            LimpiarDatos();

                            txtCorreoElectronico.Enabled = true;
                            txtContrasenia.Enabled = true;
                            txtConfirmarContrasenia.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Por favor revise si los datos estan correctos o  faltan");
                    }
                }
                    else
                    {
                        MessageBox.Show("Lo sentimos, la contraseña debe ser minimo de 5 caracteres");
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que ningun campo este vacio");
            }
        }

        private void tsbEstadoInactivo_Click(object sender, EventArgs e)
        {
            var bll_Usuario = new BLL_Usuario();

            try
            {
                if (dgvListaDeUsuarios.SelectedRows.Count > 0)
                {
                    usuario = dgvListaDeUsuarios.SelectedRows[0].DataBoundItem as Usuario;

                    var resultado = bll_Usuario.Elimnar_USUARIO(usuario.ID);
                    MostrarUsuario();
                    MessageBox.Show("El estado de esta cuenta esta →INACTIVA←");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbEstadoActivo_Click(object sender, EventArgs e)
        {
            var bll_Usuario = new BLL_Usuario();

            try
            {
                if (dgvListaDeUsuarios.SelectedRows.Count > 0)
                {
                    usuario = dgvListaDeUsuarios.SelectedRows[0].DataBoundItem as Usuario;

                    var resultado = bll_Usuario.Activar_USUARIO(usuario.ID);
                    MostrarUsuario();
                    MessageBox.Show("El estado de esta cuenta esta →ACTIVA←");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void linkLabelHabilitar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCorreoElectronico.Enabled = true;
            txtContrasenia.Enabled = true;
            txtConfirmarContrasenia.Enabled = true;
            LimpiarDatos();
        }
    }
    }

