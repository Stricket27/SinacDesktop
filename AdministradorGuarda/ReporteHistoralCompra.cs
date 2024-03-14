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
    public partial class ReporteHistoralCompra : UserControl
    {
        public ReporteHistoralCompra()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            lista_FACTURASTableAdapter.Fill(sINACDataSeHistorialCompra.Lista_FACTURAS);

            reportViewer1.RefreshReport();

        }
    }
}
