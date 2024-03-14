using BLL;
using Entities;
using Proyecto.SINAC.Idiomas;
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
    public partial class frmVentanPrincipal : Form
    {
        public Usuario usuario1 { get; set; }


        public frmVentanPrincipal()
        {
            InitializeComponent();
        }

        private void LinkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrarU frm = new RegistrarU();
            frm.Show();
        }

        private void btnIniciarSeccion_Click(object sender, EventArgs e)
        {
            //Usuario usuario1 = new Usuario() ;
            try
            {
                var usuario = new BLL_Usuario();
                usuario1 = usuario.Login_USUARIO(txtCorreoElectronico.Text, txtContrasenia.Text);

                if (usuario1 != null)
                {
                    MessageBox.Show("Te damos la bienvenida " + usuario1.Nombre + " " + usuario1.Apellido);
                    VentanaPrincipal frm = new VentanaPrincipal();
                    frm.usuario = usuario1;
                    frm.ShowDialog();

                }
                else
                {
                    labelMensajeError.Visible = true;
                    labelMensajeError.Text = "Datos incorrectos o su cuenta esta inactivo hasta el momento" +
                        "\nSi intento varias veces, por favor hablar con el " +
                        "\nadministrador de esta aplicación";
                }
                //if (rdbEspanol.Checked)
                //{
                //    labelMensajeError.Visible = true;
                //    labelMensajeError.Text = "Datos incorrectos o su cuenta esta inactivo hasta el momento" +
                //        "\n Si intento varias veces, por favor hablar con el administrador de esta aplicación";
                //}
                if (rdbEnglish.Checked)
                {
                    labelMensajeError.Visible = true;
                    labelMensajeError.Text = "Incorrect data or your account is inactive so far" +
                        "\n If I try multiple times, please speak to the administrator of this application";
                }
                LimpiarDatos();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        private void LinkRecuperarContrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContrasenia frm = new RecuperarContrasenia();
            frm.Show();
        }

        private void labelMensajeError_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarDatos()
        {
            txtCorreoElectronico.Text = "";
            txtContrasenia.Text = "";
            labelMensajeError.Visible = false;
        }

        private void IdiomaEspanol()
        {
            label1.Text = ResIniciarSeccion.Bienvenidos;
            label2.Text = ResIniciarSeccion.IngresarCorreoElectronico;
            label3.Text = ResIniciarSeccion.IngresarContrasenia;
            btnIniciarSeccion.Text = ResIniciarSeccion.IniciarSeccion;
            LinkRegistrarse.Text = ResIniciarSeccion.Registrarse;
            LinkRecuperarContrasenia.Text = ResIniciarSeccion.RecuperarContrasenia;
            rdbEnglish.Text = ResIniciarSeccion.Ingles;
        }

        private void IdiomaIngles()
        {
            label1.Text = ResIniciarSeccion_en_USA.Bienvenidos;
            label2.Text = ResIniciarSeccion_en_USA.IngresarCorreoElectronico;
            label3.Text = ResIniciarSeccion_en_USA.IngresarContrasenia;
            btnIniciarSeccion.Text = ResIniciarSeccion_en_USA.IniciarSeccion;
            LinkRegistrarse.Text = ResIniciarSeccion_en_USA.Registrarse;
            LinkRecuperarContrasenia.Text = ResIniciarSeccion_en_USA.RecuperarContrasenia;
            rdbEspanol.Text = ResIniciarSeccion_en_USA.Espanol;
        }

        private void frmVentanPrincipal_Load(object sender, EventArgs e)
        {
            IdiomaEspanol();
        }

        private void rdbEspanol_CheckedChanged(object sender, EventArgs e)
        {
            labelMensajeError.Visible = false;
            IdiomaEspanol();
        }

        private void rdbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            labelMensajeError.Visible = false;
            IdiomaIngles();
        }
    }
}
