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

namespace Proyecto.SINAC.AdministradorGuarda
{
    public partial class Disponibilidades : UserControl
    {
        public Disponibilidad disponibilidad = new Disponibilidad(); // Global //
        public AreaConservacion areaConservacion { get; set; } // Global //
        public Usuario usuario1 { get; set; }
        public Disponibilidades()
        {
            InitializeComponent();
        }

        private void Disponibilidades_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            Mostrar_Disponibilidad();
            LimpiarDatos();
            HabilitarCampos();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                disponibilidad.ID = disponibilidad.ID;
                disponibilidad.IDAreaConservacion = (cmbAreaDeConservacion.SelectedItem as AreaConservacion).ID;
                disponibilidad.HoraDeInicio = mtbHorarioInicio.Text;
                disponibilidad.HoraFinal = mtbHorarioFinal.Text;
                disponibilidad.CantidadEntradas = decimal.ToInt32(mudCantidadDenEntradas.Value);
                disponibilidad.Precio = float.Parse(txtPrecio.Text);

                disponibilidad.FechaDeReservacion = dtpFechaReservacion.Value.Date.Date;

                var bll_Disponibilidad = new BLL_Disponibilidad();
                var resultado = bll_Disponibilidad.Insertar_DISPONIBILIDAD(disponibilidad);
                MessageBox.Show(resultado);
                Mostrar_Disponibilidad();
                LimpiarDatos();

                labelMensajeAdvertencia.Visible = false;
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
                disponibilidad = dgvDisponibilidad.SelectedRows[0].DataBoundItem as Disponibilidad;

                disponibilidad.ID = disponibilidad.ID;
                disponibilidad.IDAreaConservacion = (cmbAreaDeConservacion.SelectedItem as AreaConservacion).ID;
                disponibilidad.HoraDeInicio = mtbHorarioInicio.Text;
                disponibilidad.HoraFinal = mtbHorarioFinal.Text;
                disponibilidad.CantidadEntradas = decimal.ToInt32(mudCantidadDenEntradas.Value);
                disponibilidad.Precio = float.Parse(txtPrecio.Text);

                disponibilidad.FechaDeReservacion = dtpFechaReservacion.Value.Date;

                var bll_Disponibilidad = new BLL_Disponibilidad();
                var resultado = bll_Disponibilidad.Editar_DISPONIBILIDAD(disponibilidad);
                MessageBox.Show("La disponibilidad fue editado");
                Mostrar_Disponibilidad();
                LimpiarDatos();

                labelMensajeAdvertencia.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que ningun campo este vacio");
            }



            
        }

        private void CargarComboBox()
        {
            var bll_Area = new BLL_AreaDeConservacion();
            List<AreaConservacion> listaAC = null;
            listaAC = bll_Area.Mostrar_AREACONSERVACION();
            
            if (usuario1.Profesion == Profesion.Administrador)
            {
                foreach (AreaConservacion area in listaAC)
                {
                    cmbAreaDeConservacion.Items.Add(area);
                    
                }
            }
            else
            {
                foreach (AreaConservacion area in listaAC)
                {
                    if (usuario1.ID == area.IdUsuario)
                    {
                        cmbAreaDeConservacion.Items.Add(area);
                        break;
                    }
                }
            }
            cmbAreaDeConservacion.DisplayMember = ToString();
            cmbAreaDeConservacion.ValueMember = "ID";

        }

        private void Mostrar_Disponibilidad()
        {
            var bll_Disponibilidad = new BLL_Disponibilidad();
            var bll_Area = new BLL_AreaDeConservacion();
            List<AreaConservacion> listaA = new List<AreaConservacion>();
            List<Disponibilidad> listaD = new List<Disponibilidad>();
            

            if (usuario1.Profesion == Profesion.Administrador)
            {
                dgvDisponibilidad.DataSource = bll_Disponibilidad.Mostrar_DISPONIBILIDAD();
            }
            else
            {
                foreach (AreaConservacion area in bll_Area.Mostrar_AREACONSERVACION())
                {
                    foreach (Disponibilidad ds in bll_Disponibilidad.Mostrar_DISPONIBILIDAD())
                    {
                        if (ds.IDAreaConservacion == area.ID && area.IdUsuario == usuario1.ID)
                        {
                            disponibilidad = ds;
                            listaD.Add(disponibilidad);
                            dgvDisponibilidad.DataSource = listaD;
                        }
                    }
                }
                dgvDisponibilidad.DataSource = bll_Disponibilidad.Mostrar_DISPONIBILIDAD();
                dgvDisponibilidad.DataSource = listaD;
            }
            
        }
        private void dgvDisponibilidad_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDisponibilidad.SelectedRows.Count > 0)
                {
                    var disponibilidad = (Disponibilidad)dgvDisponibilidad.SelectedRows[0].DataBoundItem;
                    cmbAreaDeConservacion.SelectedItem = disponibilidad.IDAreaConservacion;
                    mtbHorarioInicio.Text = disponibilidad.HoraDeInicio;
                    mtbHorarioFinal.Text = disponibilidad.HoraFinal;
                    mudCantidadDenEntradas.Value = disponibilidad.CantidadEntradas;
                    txtPrecio.Text = disponibilidad.Precio.ToString();
                    labelMensajeAdvertencia.Visible = true;

                    dtpFechaReservacion.Value = disponibilidad.FechaDeReservacion;

                    labelMensajeAdvertencia.Text = "ADVERTENCIA: Si vas a editar la disponibilidad, verifique que sea mismo número de area" +
                        "\n Puedes ver el número en la fila en: Número de area";
                }
                if (usuario1.Profesion == Profesion.GuardaParque)
                {
                    dtpFechaReservacion.Enabled = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            var bll_Disponibilidad = new BLL_Disponibilidad();

            try
            {
                if (dgvDisponibilidad.SelectedRows.Count > 0)
                {
                    disponibilidad = dgvDisponibilidad.SelectedRows[0].DataBoundItem as Disponibilidad;

                    var resultado = bll_Disponibilidad.Eliminar_Disponibilidad(disponibilidad.ID);
                    Mostrar_Disponibilidad();
                    MessageBox.Show("Esta disponibilidad fue eliminado");
                    LimpiarDatos();
                }
            }
            catch (Exception)
            {

                throw;
            }
            labelMensajeAdvertencia.Visible = false;
        }

        private void LimpiarDatos()
        {
            cmbAreaDeConservacion.SelectedIndex = -1;
            mtbHorarioInicio.Text = "";
            mtbHorarioFinal.Text = "";
            mudCantidadDenEntradas.Value = 0;
            txtPrecio.Text = "";
            dtpFechaReservacion.Value = DateTime.Now;
        }

        private void labelMensajeAdvertencia_Click(object sender, EventArgs e)
        {

        }

        private void HabilitarCampos()
        {
            if (usuario1.Profesion == Profesion.GuardaParque)
            {
                tsbAgregar.Visible = false;
                tsbEliminar.Visible = false;
            }
        }



    }
}
