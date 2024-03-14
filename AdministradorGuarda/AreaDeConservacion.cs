using System;
using BLL;
using Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Proyecto.SINAC.AdministradorGuarda
{
    public partial class AreaDeConservacion : UserControl
    {
        public AreaConservacion area { get; set; }
        public Usuario usuario1 { get; set; }
        public AreaDeConservacion()
        {
            InitializeComponent();
        }
        private void AreaDeConservacion_Load(object sender, EventArgs e)
        {
            MostrarTablaAREA();
            CargarComboBoxGuarda();
            MostrarFotografia();
            HabilidarBotones();
        }

        private void ptbFotografia_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Selecione un parque";
                openFile.SupportMultiDottedExtensions = true;
                openFile.DefaultExt = "*.jpg";
                openFile.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
                openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFile.FileName = "";

                if (openFile.ShowDialog(this) == DialogResult.OK)
                {
                    this.ptbFotografia.ImageLocation = openFile.FileName;
                    ptbFotografia.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] CadenaBytes = File.ReadAllBytes(openFile.FileName);

                    ptbFotografia.Tag = (byte[])CadenaBytes;


                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarTablaAREA()
        {

            var bll_Area = new BLL_AreaDeConservacion();
            
            

            if (usuario1.Profesion == Profesion.Administrador.ToString())
            {
            dgvAreaConservacion.DataSource = bll_Area.Mostrar_AREACONSERVACION();

            }
            else 
            {
                List<AreaConservacion> listaAreaGuardaParque = new List<AreaConservacion>();
                AreaConservacion areaGuardaParque = null;
                foreach (AreaConservacion area in bll_Area.Mostrar_AREACONSERVACION())
                {
                    if (area.IdUsuario == usuario1.ID)
                    {
                        
                        areaGuardaParque = area;
                        listaAreaGuardaParque.Add(areaGuardaParque);
                        break;
                    }
                }
                dgvAreaConservacion.DataSource = listaAreaGuardaParque;
            }
            dgvAreaConservacion.AutoGenerateColumns = false;
            dgvAreaConservacion.Columns[3].Width = 10;
            dgvAreaConservacion.AutoResizeColumns();
            dgvAreaConservacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            foreach (DataGridViewRow data in dgvAreaConservacion.Rows)
            {
                dgvAreaConservacion.RowTemplate.Height = 100;
                AreaConservacion conservacion = data.DataBoundItem as AreaConservacion;
            }

            ptbFotografia.Image = Properties.Resources.camara;
            ptbFotografia.SizeMode = PictureBoxSizeMode.CenterImage;


        }

        private void MostrarFotografia()
        {
            this.ptbFotografia.Image = Properties.Resources.camara;
            ptbFotografia.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void dgvAreaConservacion_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvAreaConservacion.SelectedRows.Count > 0)
                {
                    var area = (AreaConservacion)dgvAreaConservacion.SelectedRows[0].DataBoundItem;
                    txtCodigo.Text = area.Codigo;
                    txtNombre.Text = area.Nombre;

                    MemoryStream memory = new MemoryStream(area.Fotografia);
                    ptbFotografia.Image = Image.FromStream(memory);

                    txtSitioWeb.Text = area.SitioWeb;
                    txtTipoArea.Text = area.TipoArea;
                    cmbGuardaParque.SelectedValue = area.IdUsuario.ToString();

                    labelMensajeAdvertencia.Visible = true;
                    labelMensajeAdvertencia.Text = "ADVERTENCIA: Si vas a editar el area de conservación, verifique que sea mismo número de guarda parque" +
                        "\nY tambien busque la fotografia del parque, que esta e esta aplicación" +
                        "\n Puedes ver el número en la fila en: Número de guarda parque";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            area = new AreaConservacion();
            try
            {
                area.ID = area.ID;
                area.Codigo = txtCodigo.Text;
                area.Nombre = txtNombre.Text;

                MemoryStream memory = new MemoryStream();
                ptbFotografia.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
                area.Fotografia = memory.ToArray();

                //area.Fotografia = (byte[])ptbFotografia.Tag;
                area.SitioWeb = txtSitioWeb.Text;
                area.TipoArea = txtTipoArea.Text;
                area.IdUsuario = (cmbGuardaParque.SelectedItem as Usuario).ID;

                var bll_Area = new BLL_AreaDeConservacion();
                var resultado = bll_Area.Insertar_AREACONSERVACION(area);
                MessageBox.Show(resultado);
                MostrarTablaAREA();
                MostrarFotografia();
                limpiarDatos();

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
                area = dgvAreaConservacion.SelectedRows[0].DataBoundItem as AreaConservacion;


                area.ID = area.ID;
                area.Codigo = txtCodigo.Text;
                area.Nombre = txtNombre.Text;
                area.Fotografia = (byte[])ptbFotografia.Tag;
                area.SitioWeb = txtSitioWeb.Text;
                area.TipoArea = txtTipoArea.Text;
                area.IdUsuario = (cmbGuardaParque.SelectedItem as Usuario).ID;

                var bll_Area = new BLL_AreaDeConservacion();
                var resultado = bll_Area.Editar_AREACONSERVACION(area);
                MessageBox.Show("Esta area a sido modificada");
                MostrarTablaAREA();
                MostrarFotografia();
                limpiarDatos();

                labelMensajeAdvertencia.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que ningun campo este vacio");
            }
            
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            var bll_Area = new BLL_AreaDeConservacion();

            try
            {
                if (dgvAreaConservacion.SelectedRows.Count > 0)
                {
                    area = dgvAreaConservacion.SelectedRows[0].DataBoundItem as AreaConservacion;

                    var resultado = bll_Area.Eliminar_AreaConservacion(area.ID);
                    
                    MessageBox.Show("Esta area a sido eliminada");
                    MostrarTablaAREA();
                    MostrarFotografia();
                    limpiarDatos();

                    labelMensajeAdvertencia.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void verImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ptbFotografia.Tag != null)
                {

                    if (!Directory.Exists(@"C:\temp"))
                        Directory.CreateDirectory(@"C:\temp");

                    File.WriteAllBytes(@"C:\temp\imagen.jpg", (byte[])this.ptbFotografia.Tag);
                    Process.Start(@"C:\temp\imagen.jpg");
                }

            }
            catch (Exception)
            {
                // Mensaje de Error
                throw;
            }
        }

        private void limpiarDatos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtSitioWeb.Text = "";
            txtTipoArea.Text = "";
            cmbGuardaParque.SelectedIndex = -1;
            ptbFotografia.Image = Properties.Resources.camara;
        }

        private void CargarComboBoxGuarda()
        {
            var bll_Usuario = new BLL_Usuario();
            List<Usuario> listaU = null;
            listaU = bll_Usuario.buscarGuardaParque();
            if (usuario1.Profesion == Profesion.Administrador)
            {
                foreach (Usuario usuario in listaU)
                {
                    cmbGuardaParque.Items.Add(usuario);
                }
            }
            else
            {
                foreach (Usuario usuario in listaU)
                {
                    if (usuario1.ID == usuario.ID)
                    {
                        cmbGuardaParque.Items.Add(usuario);
                        break;
                    }
                }
                
            }

            cmbGuardaParque.DisplayMember = ToString();
            cmbGuardaParque.ValueMember = "ID";

        }

        private void HabilidarBotones()
        {
            if (usuario1.Profesion == Profesion.GuardaParque)
            {
                tsbAgregar.Visible = false;
                tsbEliminar.Visible = false;
            }
        }









































            }
        }
