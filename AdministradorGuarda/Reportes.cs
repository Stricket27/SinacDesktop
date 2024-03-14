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
    public partial class Reportes : UserControl
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panelFondo.Controls.Clear();
            ReporteHistoralCompra frm = new ReporteHistoralCompra();
            panelFondo.Controls.Add(frm);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            panelFondo.Controls.Clear();
            ReporteGraficaBarra frm = new ReporteGraficaBarra();
            panelFondo.Controls.Add(frm);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panelFondo.Controls.Clear();
            ReporteListaVisitantes frm = new ReporteListaVisitantes();
            panelFondo.Controls.Add(frm);
        }
    }
}
