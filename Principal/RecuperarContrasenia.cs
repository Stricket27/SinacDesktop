using BLL;
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
    public partial class RecuperarContrasenia : Form
    {
        public RecuperarContrasenia()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new BLL_Usuario();
                var resultado = usuario.Recuperar_CONTRASENIA(txtCorreo.Text);

                MessageBox.Show("Su contraseña fue enviado a su correo electronico, por favor revisar la entrega");
                txtCorreo.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor ingresar su correo electronico o revisar si esta correcto");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
