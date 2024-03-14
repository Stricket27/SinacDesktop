using Entities;
using Proyecto.SINAC.AdministradorGuarda;
using Proyecto.SINAC.Cliente;
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
    public partial class VentanaPrincipal : Form
    {
        public Usuario usuario { get; set; }

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            CargarPanelesEIformacion();
        }

        private void CargarPanelesEIformacion()
        {
            labelCorreo.Text = usuario.CorreoElectronico;
            labelProfesion.Text = usuario.Profesion;
            labelNombreCompleto.Text = usuario.Nombre + " " + usuario.Apellido;

            if (usuario.Profesion == Profesion.Administrador)
            {
                panelAdministrador.Visible = true;
                panelAdministrador.Dock = DockStyle.Top;
            }
            if (usuario.Profesion == Profesion.GuardaParque)
            {
                panelGuardaParque.Visible = true;
                panelGuardaParque.Dock = DockStyle.Top;
            }
            if (usuario.Profesion != Profesion.Administrador && usuario.Profesion != Profesion.GuardaParque)
            {
                panelUsuario.Visible = true;
                panelUsuario.Dock = DockStyle.Top;
            }

            panelBotonEditarPerfil.Dock = DockStyle.Top;
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            panelDeFondo.Controls.Clear();
            EditarPerfil editar = new EditarPerfil();
            editar.usuario = usuario;
            panelDeFondo.Controls.Add(editar);
        }

        private void btnCerrarSeccion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar sección?", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void btnRegistarUsuarios_Click(object sender, EventArgs e)
        {
            panelDeFondo.Controls.Clear();
            RegistarUsuarios registar = new RegistarUsuarios();
            panelDeFondo.Controls.Add(registar);
        }

        private void btnGestionarA_Click(object sender, EventArgs e)
        {
            panelDeFondo.Controls.Clear();
            AreaDeConservacion area = new AreaDeConservacion();
            area.usuario1 = usuario;
            panelDeFondo.Controls.Add(area);
        }

        private void btnGestionarGP_Click(object sender, EventArgs e)
        {
            panelDeFondo.Controls.Clear();
            AreaDeConservacion area = new AreaDeConservacion();
            area.usuario1 = usuario;
            panelDeFondo.Controls.Add(area);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            panelDeFondo.Controls.Clear();
            ReservacionYCompra compra = new ReservacionYCompra();
            panelDeFondo.Controls.Add(compra);
        }

        private void btnDisponibilidades_Click(object sender, EventArgs e)
        {
            panelDeFondo.Controls.Clear();
            Disponibilidades frm = new Disponibilidades();
            frm.usuario1 = usuario;
            panelDeFondo.Controls.Add(frm);
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            panelDeFondo.Controls.Clear();
            Disponibilidades frm = new Disponibilidades();
            frm.usuario1 = usuario;
            panelDeFondo.Controls.Add(frm);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            panelDeFondo.Controls.Clear();
            Reportes reportes = new Reportes();
            panelDeFondo.Controls.Add(reportes);
        }
    }
}
