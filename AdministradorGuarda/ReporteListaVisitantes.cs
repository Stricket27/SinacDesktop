﻿using System;
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
    public partial class ReporteListaVisitantes : UserControl
    {
        public ReporteListaVisitantes()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            lista_VisitantesTableAdapter.Fill(sINACDataSetListaVisitantes.Lista_Visitantes);

            reportViewer1.RefreshReport();

        }
    }
}
