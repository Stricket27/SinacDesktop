
namespace Proyecto.SINAC.AdministradorGuarda
{
    partial class ReporteListaVisitantes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sINACDataSetListaVisitantes = new Proyecto.SINAC.SINACDataSetListaVisitantes();
            this.listaVisitantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_VisitantesTableAdapter = new Proyecto.SINAC.SINACDataSetListaVisitantesTableAdapters.Lista_VisitantesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINACDataSetListaVisitantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVisitantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerarReporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.SystemColors.Window;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnGenerarReporte.Location = new System.Drawing.Point(544, 29);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(209, 50);
            this.btnGenerarReporte.TabIndex = 0;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetListaVisitantes";
            reportDataSource3.Value = this.listaVisitantesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.SINAC.AdministradorGuarda.ReportWListaVisitantes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1261, 561);
            this.reportViewer1.TabIndex = 1;
            // 
            // sINACDataSetListaVisitantes
            // 
            this.sINACDataSetListaVisitantes.DataSetName = "SINACDataSetListaVisitantes";
            this.sINACDataSetListaVisitantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaVisitantesBindingSource
            // 
            this.listaVisitantesBindingSource.DataMember = "Lista_Visitantes";
            this.listaVisitantesBindingSource.DataSource = this.sINACDataSetListaVisitantes;
            // 
            // lista_VisitantesTableAdapter
            // 
            this.lista_VisitantesTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteListaVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteListaVisitantes";
            this.Size = new System.Drawing.Size(1261, 661);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sINACDataSetListaVisitantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVisitantesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerarReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listaVisitantesBindingSource;
        private SINACDataSetListaVisitantes sINACDataSetListaVisitantes;
        private SINACDataSetListaVisitantesTableAdapters.Lista_VisitantesTableAdapter lista_VisitantesTableAdapter;
    }
}
