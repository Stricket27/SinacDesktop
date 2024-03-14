using BLL;
using Entities;
using Proyecto.SINAC.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Proyecto.SINAC.Cliente
{
    /// <summary>
    /// ESCRITORIO ESCRITORIO
    /// </summary>
    public partial class ReservacionYCompra : UserControl
    {
        #region Clases/Entities
        public AreaConservacion oArea { get; set; }

        public Disponibilidad oDisponibilidad { get; set; }

        public LineaDeDetalle oLineaDeDetalle;

        public Usuario oUsuario = new Usuario();

        public OrdenDeCompra oOrdenCompra = new OrdenDeCompra();

        public Tarjeta oTarjeta = null;

        public Pago oPago { get; set; }

        #endregion



        public ReservacionYCompra()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            Datos_VISITANTE();
            //FicharOrden();

        }

        private void CargarComboBox()
        {
            //AREA DE CONSERVACION
            var bll_Area = new BLL_AreaDeConservacion();
            List<AreaConservacion> listaAC = null;
            listaAC = bll_Area.Mostrar_AREACONSERVACION();

            foreach (AreaConservacion area in listaAC)
            {
                cmbTipoArea.Items.Add(area);
                

            }
            cmbTipoArea.DisplayMember = "Nombre";
            cmbTipoArea.ValueMember = "ID";
            //

            //TIPO DE PERSONA
            //cmbTipoPersona.SelectedIndex = -1;
            cmbTipoPersona.DataSource = Enum.GetValues(typeof(TipoPersona));
            //

            //TIPO DE TARJETA
            //cmbTipoTarjeta.SelectedIndex = -1;
            cmbTipoTarjeta.DataSource = Enum.GetValues(typeof(TipoTarjeta));
            //

            //TIPO DE MONEDA
            //cmbMonedaPago.SelectedIndex = -1;
            cmbMonedaPago.DataSource = Enum.GetValues(typeof(Moneda));
            //

            //PAIS DE VISITANTE
            
            cmbPaisResidencia1.DataSource = Enum.GetValues(typeof(PaisResidencia));
            cmbPaisResidencia2.DataSource = Enum.GetValues(typeof(PaisResidencia));
            //cmbPaisResidencia1.SelectedIndex = -1;
            //cmbPaisResidencia2.SelectedIndex = -1;
            //
        }

        private void cmbTipoArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrar_FOTOGRAFIA();
            Mostrar_SitioWeb();
            
        }

        private void Mostrar_FOTOGRAFIA()
        {
            var area = (AreaConservacion)cmbTipoArea.SelectedItem;

            MemoryStream memory = new MemoryStream(area.Fotografia);
            ptbFotografia.Image = System.Drawing.Image.FromStream(memory);

            linkLabelSitioWeb.Visible = true;
            linkLabelSitioWeb.Text = area.SitioWeb;
        }

        private void linkLabelSitioWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(info);
        }

        private void Mostrar_SitioWeb()
        {
            linkLabelSitioWeb.Links.Clear();
            var area = (AreaConservacion)cmbTipoArea.SelectedItem;
            linkLabelSitioWeb.Links.Add(0, 0, area.SitioWeb);
        }

        private void Mostrar_Fecha()
        {
            var bll_D = new BLL_Disponibilidad();
            var bll_A = new BLL_AreaDeConservacion();
            List<Disponibilidad> listaD = new List<Disponibilidad>();

            foreach (var area in bll_A.Mostrar_AREACONSERVACION())
            {
                foreach (var disponible in bll_D.Mostrar_DISPONIBILIDAD())
                {
                    if (area.ID == disponible.IDAreaConservacion && dtpFechaReservacion.Value.Date ==
                        disponible.FechaDeReservacion)
                    {
                        oDisponibilidad = disponible;
                        listaD.Add(oDisponibilidad);
                    }
                }
            }
            dgvFechaReservacion.DataSource = listaD;
        }
        
        private void dtpFechaReservacion_ValueChanged(object sender, EventArgs e)
        {
            Mostrar_Fecha();
        }

        private void nudCantidadEntradas_ValueChanged(object sender, EventArgs e)
        {
            Datos_VISITANTE();
        }

        private void Datos_VISITANTE()
        {
            if (nudCantidadEntradas.Value == 1)
            {
                txtNombreAdulto1.Text = "NINGUNO";
                txtNombreAdulto2.Text = "NINGUNO";
                txtIdentificacionAdulto1.Text = "0";
                txtIdentificacionAdulto2.Text = "0";
                //cmbPaisResidencia1.SelectedItem = "NIGUNO";
                //cmbPaisResidencia2.SelectedItem = "NINGUNO";

                txtNombreAdulto1.Enabled = false;
                txtIdentificacionAdulto1.Enabled = false;
                cmbPaisResidencia1.Enabled = false;

                txtNombreAdulto2.Enabled = false;
                txtIdentificacionAdulto2.Enabled = false;
                cmbPaisResidencia2.Enabled = false;

            }
            if (nudCantidadEntradas.Value == 2)
            {
                txtNombreAdulto1.Enabled = true;
                txtIdentificacionAdulto1.Enabled = true;
                cmbPaisResidencia1.Enabled = true;

                txtNombreAdulto1.Text = "";
                txtIdentificacionAdulto1.Text = "";
                cmbPaisResidencia1.SelectedItem = "";

                txtNombreAdulto1.Text = "";
                txtIdentificacionAdulto1.Text = "";
                cmbPaisResidencia1.SelectedItem = "";

                txtNombreAdulto2.Text = "NINGUNO";
                txtIdentificacionAdulto2.Text = "0";
                //cmbPaisResidencia2.SelectedItem = "NINGUNO";
            }
            if (nudCantidadEntradas.Value == 3)
            {
                txtNombreAdulto1.Enabled = true;
                txtIdentificacionAdulto1.Enabled = true;
                cmbPaisResidencia1.Enabled = true;

                txtNombreAdulto2.Enabled = true;
                txtIdentificacionAdulto2.Enabled = true;
                cmbPaisResidencia2.Enabled = true;

                txtNombreAdulto1.Text = "";
                txtIdentificacionAdulto1.Text = "";
                cmbPaisResidencia1.SelectedItem = "";

                txtNombreAdulto2.Text = "";
                txtIdentificacionAdulto2.Text = "";
                cmbPaisResidencia2.SelectedItem = "";

            }
        }

        private void btnAgregarALALista_Click(object sender, EventArgs e)
        {
            try
            {
                oArea = new AreaConservacion();
                int indice = dgvFechaReservacion.Rows.Count;
                oLineaDeDetalle = new LineaDeDetalle();
                if (indice >= 0)
                {
                    Disponibilidad disponibilidad = (Disponibilidad)dgvFechaReservacion.SelectedRows[0].DataBoundItem;

                    if (cmbTipoPersona.SelectedIndex != -1)
                    {
                        if (nudCantidadEntradas.Value != 0)
                        {
                            disponibilidad.CantidadEntradas = int.Parse(nudCantidadEntradas.Value.ToString());
                            oLineaDeDetalle.Cantidad = disponibilidad.CantidadEntradas;
                            oLineaDeDetalle.NCVisitante1 = txtNombreAdulto1.Text;
                            oLineaDeDetalle.NCVisitante2 = txtNombreAdulto2.Text;
                            oLineaDeDetalle.IVisitante1 = txtIdentificacionAdulto1.Text;
                            oLineaDeDetalle.IVisitante2 = txtIdentificacionAdulto2.Text;
                            oLineaDeDetalle.PRVisitante1 = (PaisResidencia)cmbPaisResidencia1.SelectedItem;
                            oLineaDeDetalle.PRVisitante2 = (PaisResidencia)cmbPaisResidencia2.SelectedItem;
                        }
                        var bll_Orden = new BLL_OrdenDeCompra();
                        bll_Orden.Insertar_ORDEN_COMPRA(DateTime.Now, Cache.ID, Cache.IDArea);


                    }


                    string texto = "Cantidad de entradas: " + nudCantidadEntradas.Value.ToString() +
                        "\n  " + "Tipo de persona: " + cmbTipoPersona.SelectedItem;

                    panelDatosPago.Visible = true;

                    lstListaDeCompra.Items.Add(texto);

                    oLineaDeDetalle.disponibilidad = disponibilidad;
                    oOrdenCompra.AgregarLineaDetalle(oLineaDeDetalle);
                    txtSubTotal.Text = oOrdenCompra.SubTotal().ToString();
                    txtImpuesto.Text = oOrdenCompra.TotalImpuesto().ToString();
                    txtTotal.Text = oOrdenCompra.TotalCompra().ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que ningun campo este vacio");
            }

            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nudCantidadEntradas.Value = 0;
            cmbTipoPersona.SelectedIndex = -1;
            lstListaDeCompra.Items.Clear();
            txtNombreAdulto1.Text = "";
            txtNombreAdulto2.Text = "";
            txtIdentificacionAdulto1.Text = "";
            txtIdentificacionAdulto2.Text = "";
            cmbPaisResidencia1.SelectedIndex = -1;
            cmbPaisResidencia2.SelectedIndex = 1;
        }

        private void btnValidarTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                oTarjeta = new Tarjeta();

                oTarjeta.Numero = mtbNumeroTarjeta.Text;
                oTarjeta.MesDeVencimiento = int.Parse(mtbMesVencimiento.Text);
                oTarjeta.AnioDeVencimiento = int.Parse(mtbAnioVencimiento.Text);
                oTarjeta.Codigo = mtbCodigoSeguridad.Text;
                oTarjeta.tipo = (TipoTarjeta)cmbTipoTarjeta.SelectedItem;

                int digitoValidad = 0;

                if (oTarjeta.tipo == TipoTarjeta.Master_CARD)
                {
                    digitoValidad = int.Parse(oTarjeta.Numero.Substring(0, 2));
                }
                else
                {
                    digitoValidad = int.Parse(oTarjeta.Numero.Substring(0, 1));
                }

                if (oTarjeta.ValidarFecha()/* && oTarjeta.ValidarTipoTarjeta(digitoValidad)*/)
                {
                    MessageBox.Show("Tarjeta aceptada");
                btnConfirmarCompra.Visible = true;
                btnCancelarCompra.Visible = true;
                }
                else
                {
                    MessageBox.Show("Tarjeta no aceptada");
                }

                var bll_Tarjeta = new BLL_Tarjeta();

                bll_Tarjeta.Insertar_TARJETA(oTarjeta);

            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que ningun campo este vacio");
            }

            
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            oLineaDeDetalle = new LineaDeDetalle();

            try
            {
                oOrdenCompra.Usuario = oUsuario;
                oOrdenCompra.areaConservacion = (AreaConservacion)cmbTipoArea.SelectedItem;
                oOrdenCompra.RealizarPago(oOrdenCompra.TotalCompra(), (Moneda)cmbMonedaPago.SelectedItem);

                foreach (var linea in oOrdenCompra.LISTAlineaDeDetalles)
                {

                    var bll_Disponibilidad = new BLL_Disponibilidad();
                    bll_Disponibilidad.Actualizar_STOCK(linea.disponibilidad.ID, (int)nudCantidadEntradas.Value);
                }

                var bll_Orden = new BLL_OrdenDeCompra();
                bll_Orden.SeleccionarNumeroOrden();

                var bll_Linea = new BLL_LineaDeDetalle();
                bll_Linea.Insertar_LINEA_DETALLE((int)nudCantidadEntradas.Value, oDisponibilidad.ID, Cache.NumeroOrden,
                    txtNombreAdulto1.Text, txtNombreAdulto2.Text, txtIdentificacionAdulto1.Text, txtIdentificacionAdulto2.Text,
                    (PaisResidencia)cmbPaisResidencia1.SelectedItem, (PaisResidencia)cmbPaisResidencia2.SelectedItem);
                

                var bll_Pago = new BLL_Pago();
                bll_Pago.Insertar_Pago(DateTime.Now, oOrdenCompra.TotalCompra(), ((Moneda)cmbMonedaPago.SelectedItem), Cache.NumeroOrden);



                bll_Orden.Insertar_ORDEN_COMPRA(DateTime.Now, Cache.ID, oArea.ID);

                oOrdenCompra.GuardaXML();
                //oOrdenCompra.ConvertirXMLaPDF();
                oOrdenCompra.GenerarPDF();

                var bll_Usuario = new BLL_Usuario();
                bll_Usuario.EnviarArchivos();
                MessageBox.Show("Gracias por la compra, te enviamos dos archivos a tu correo" +
                    "\nMientras se envia, te enseñamos una pequeña factura");
                MessageBox.Show(oOrdenCompra.ToString());

                LimpiarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Verfique que ningun campo este vacio");
            }
        }

        int ordenID = 1;
        private void FicharOrden()
        {
            var bll_Orden = new BLL_OrdenDeCompra();
            try
            {
                if (!bll_Orden.Fichar_ORDEN(ordenID.ToString()))
                {
                    oOrdenCompra = new OrdenDeCompra();
                    oOrdenCompra.NumeroOrdenes= ordenID;
                }
                else
                {
                    ordenID++;
                    FicharOrden();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void IdiomaEspanol()
        {
            label1.Text = ResOrdenCompra.Reservacion;
            label2.Text = ResOrdenCompra.NombreParque;
            label4.Text = ResOrdenCompra.MasInformacion;
            label5.Text = ResOrdenCompra.FechaReservacion;
            label6.Text = ResOrdenCompra.Compra;
            label7.Text = ResOrdenCompra.CantidadEntradas;
            label8.Text = ResOrdenCompra.TipoPersona;
            btnAgregarALALista.Text = ResOrdenCompra.AgregaLista;
            btnCancelar.Text = ResOrdenCompra.CancelarPedido;
            label24.Text = ResOrdenCompra.SubTotal;
            label25.Text = ResOrdenCompra.Impuesto;
            label26.Text = ResOrdenCompra.Total;
            label15.Text = ResOrdenCompra.DatosVisitantes;
            label16.Text = ResOrdenCompra.Ninio;
            label9.Text = ResOrdenCompra.TiposAdminsion;
            label12.Text = ResOrdenCompra.NombreCompleto;
            label3.Text = ResOrdenCompra.Identificacion;
            label4.Text = ResOrdenCompra.PaisResidencia;
            label10.Text = ResOrdenCompra.AdultoResidente;
            label11.Text = ResOrdenCompra.AdultoResidente;
            label17.Text = ResOrdenCompra.DatosPago;
            label18.Text = ResOrdenCompra.NumeroTarjeta;
            label21.Text = ResOrdenCompra.AnioVencimiento;
            label19.Text = ResOrdenCompra.TipoTarjeta;
            label22.Text = ResOrdenCompra.CodigoSeguridad;
            label20.Text = ResOrdenCompra.MesVencimiento;
            label23.Text = ResOrdenCompra.MonedaPago;
            btnValidarTarjeta.Text = ResOrdenCompra.ValidarTarjeta;
            btnConfirmarCompra.Text = ResOrdenCompra.ConfirmarCompra;
            btnCancelarCompra.Text = ResOrdenCompra.CancelarCompra;

        }

        private void IdiomaIngles()
        {
            label1.Text = ResOrdenCompra_en_USA.Reservacion;
            label2.Text = ResOrdenCompra_en_USA.NombreParque;
            label4.Text = ResOrdenCompra_en_USA.MasInformacion;
            label5.Text = ResOrdenCompra_en_USA.FechaReservacion;
            label6.Text = ResOrdenCompra_en_USA.Compra;
            label7.Text = ResOrdenCompra_en_USA.CantidadEntradas;
            label8.Text = ResOrdenCompra_en_USA.TipoPersona;
            btnAgregarALALista.Text = ResOrdenCompra_en_USA.AgregaLista;
            btnCancelar.Text = ResOrdenCompra_en_USA.CancelarPedido;
            label24.Text = ResOrdenCompra_en_USA.SubTotal;
            label25.Text = ResOrdenCompra_en_USA.Impuesto;
            label26.Text = ResOrdenCompra_en_USA.Total;
            label15.Text = ResOrdenCompra_en_USA.DatosVisitantes;
            label16.Text = ResOrdenCompra_en_USA.Ninio;
            label9.Text = ResOrdenCompra_en_USA.TiposAdminsion;
            label12.Text = ResOrdenCompra_en_USA.NombreCompleto;
            label3.Text = ResOrdenCompra_en_USA.Identificacion;
            label4.Text = ResOrdenCompra_en_USA.PaisResidencia;
            label10.Text = ResOrdenCompra_en_USA.AdultoResidente;
            label11.Text = ResOrdenCompra_en_USA.AdultoResidente;
            label17.Text = ResOrdenCompra_en_USA.DatosPago;
            label18.Text = ResOrdenCompra_en_USA.NumeroTarjeta;
            label21.Text = ResOrdenCompra_en_USA.AnioVencimiento;
            label19.Text = ResOrdenCompra_en_USA.TipoTarjeta;
            label22.Text = ResOrdenCompra_en_USA.CodigoSeguridad;
            label20.Text = ResOrdenCompra_en_USA.MesVencimiento;
            label23.Text = ResOrdenCompra_en_USA.MonedaPago;
            btnValidarTarjeta.Text = ResOrdenCompra_en_USA.ValidarTarjeta;
            btnConfirmarCompra.Text = ResOrdenCompra_en_USA.ConfirmarCompra;
            btnCancelarCompra.Text = ResOrdenCompra_en_USA.CancelarCompra;
        }

        private void rdbEspanol_CheckedChanged(object sender, EventArgs e)
        {
            IdiomaEspanol();
        }

        private void rdbIngles_CheckedChanged(object sender, EventArgs e)
        {
            IdiomaIngles();
        }

        private void LimpiarDatos()
        {
            txtSubTotal.Text = "";
            txtImpuesto.Text = "";
            txtTotal.Text = "";
            txtNombreAdulto1.Text = "";
            txtNombreAdulto2.Text = "";
            txtIdentificacionAdulto1.Text = "";
            txtIdentificacionAdulto2.Text = "";
            cmbPaisResidencia1.SelectedIndex = -1;
            cmbPaisResidencia2.SelectedIndex = -1;
            lstListaDeCompra.Items.Clear();
            mtbNumeroTarjeta.Text = "";
            mtbMesVencimiento.Text = "";
            mtbAnioVencimiento.Text = "";
            mtbCodigoSeguridad.Text = "";
            cmbTipoTarjeta.SelectedIndex = -1;
            cmbMonedaPago.SelectedIndex = -1;
        }

    }
}
