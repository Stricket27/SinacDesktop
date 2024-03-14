
namespace Proyecto.SINAC.AdministradorGuarda
{
    partial class ReporteHistoralCompra
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sINACDataSeHistorialCompra = new Proyecto.SINAC.SINACDataSeHistorialCompra();
            this.listaFACTURASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_FACTURASTableAdapter = new Proyecto.SINAC.SINACDataSeHistorialCompraTableAdapters.Lista_FACTURASTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINACDataSeHistorialCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFACTURASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerarReporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.SystemColors.Window;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(538, 27);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(190, 42);
            this.btnGenerarReporte.TabIndex = 0;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetHistorialCompra";
            reportDataSource2.Value = this.listaFACTURASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.SINAC.AdministradorGuarda.ReportWHistorialCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1270, 565);
            this.reportViewer1.TabIndex = 1;
            // 
            // sINACDataSeHistorialCompra
            // 
            this.sINACDataSeHistorialCompra.DataSetName = "SINACDataSeHistorialCompra";
            this.sINACDataSeHistorialCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaFACTURASBindingSource
            // 
            this.listaFACTURASBindingSource.DataMember = "Lista_FACTURAS";
            this.listaFACTURASBindingSource.DataSource = this.sINACDataSeHistorialCompra;
            // 
            // lista_FACTURASTableAdapter
            // 
            this.lista_FACTURASTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteHistoralCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteHistoralCompra";
            this.Size = new System.Drawing.Size(1270, 665);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sINACDataSeHistorialCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFACTURASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerarReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listaFACTURASBindingSource;
        private SINACDataSeHistorialCompra sINACDataSeHistorialCompra;
        private SINACDataSeHistorialCompraTableAdapters.Lista_FACTURASTableAdapter lista_FACTURASTableAdapter;
    }
}
