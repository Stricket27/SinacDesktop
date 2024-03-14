
namespace Proyecto.SINAC.AdministradorGuarda
{
    partial class AreaDeConservacion
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
            this.txtTipoArea = new System.Windows.Forms.TextBox();
            this.dgvAreaConservacion = new System.Windows.Forms.DataGridView();
            this.NumeroGuarda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotografia = new System.Windows.Forms.DataGridViewImageColumn();
            this.SitioWeb = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGuardaParque = new System.Windows.Forms.ComboBox();
            this.txtSitioWeb = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.labelMensajeAdvertencia = new System.Windows.Forms.Label();
            this.ptbFotografia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaConservacion)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipoArea
            // 
            this.txtTipoArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoArea.Location = new System.Drawing.Point(182, 461);
            this.txtTipoArea.Name = "txtTipoArea";
            this.txtTipoArea.Size = new System.Drawing.Size(434, 24);
            this.txtTipoArea.TabIndex = 14;
            // 
            // dgvAreaConservacion
            // 
            this.dgvAreaConservacion.AllowUserToAddRows = false;
            this.dgvAreaConservacion.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAreaConservacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAreaConservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreaConservacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroGuarda,
            this.Codigo,
            this.Nombre,
            this.TipoArea,
            this.Fotografia,
            this.SitioWeb,
            this.ID});
            this.dgvAreaConservacion.Location = new System.Drawing.Point(632, 39);
            this.dgvAreaConservacion.Name = "dgvAreaConservacion";
            this.dgvAreaConservacion.ReadOnly = true;
            this.dgvAreaConservacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvAreaConservacion.RowTemplate.Height = 24;
            this.dgvAreaConservacion.Size = new System.Drawing.Size(767, 598);
            this.dgvAreaConservacion.TabIndex = 0;
            this.dgvAreaConservacion.SelectionChanged += new System.EventHandler(this.dgvAreaConservacion_SelectionChanged);
            // 
            // NumeroGuarda
            // 
            this.NumeroGuarda.DataPropertyName = "IdUsuario";
            this.NumeroGuarda.HeaderText = "Número de guarda parque";
            this.NumeroGuarda.MinimumWidth = 6;
            this.NumeroGuarda.Name = "NumeroGuarda";
            this.NumeroGuarda.ReadOnly = true;
            this.NumeroGuarda.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo de area";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre del parque";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // TipoArea
            // 
            this.TipoArea.DataPropertyName = "TipoArea";
            this.TipoArea.HeaderText = "Lugar de area";
            this.TipoArea.MinimumWidth = 6;
            this.TipoArea.Name = "TipoArea";
            this.TipoArea.ReadOnly = true;
            this.TipoArea.Width = 125;
            // 
            // Fotografia
            // 
            this.Fotografia.DataPropertyName = "Fotografia";
            this.Fotografia.HeaderText = "Fotografia";
            this.Fotografia.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Fotografia.MinimumWidth = 6;
            this.Fotografia.Name = "Fotografia";
            this.Fotografia.ReadOnly = true;
            this.Fotografia.Width = 125;
            // 
            // SitioWeb
            // 
            this.SitioWeb.DataPropertyName = "SitioWeb";
            this.SitioWeb.HeaderText = "Sitio web";
            this.SitioWeb.MinimumWidth = 6;
            this.SitioWeb.Name = "SitioWeb";
            this.SitioWeb.ReadOnly = true;
            this.SitioWeb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SitioWeb.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // cmbGuardaParque
            // 
            this.cmbGuardaParque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGuardaParque.FormattingEnabled = true;
            this.cmbGuardaParque.Location = new System.Drawing.Point(182, 506);
            this.cmbGuardaParque.Name = "cmbGuardaParque";
            this.cmbGuardaParque.Size = new System.Drawing.Size(257, 26);
            this.cmbGuardaParque.TabIndex = 12;
            // 
            // txtSitioWeb
            // 
            this.txtSitioWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSitioWeb.Location = new System.Drawing.Point(182, 411);
            this.txtSitioWeb.Name = "txtSitioWeb";
            this.txtSitioWeb.Size = new System.Drawing.Size(434, 24);
            this.txtSitioWeb.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(192, 206);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(424, 24);
            this.txtNombre.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(192, 169);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(138, 24);
            this.txtCodigo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Guarda parque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sitio web";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fotografia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del parque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbEditar,
            this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1477, 30);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.Image = global::Proyecto.SINAC.Properties.Resources.add;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(95, 27);
            this.tsbAgregar.Text = "Agregar";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::Proyecto.SINAC.Properties.Resources.editar;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(78, 27);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::Proyecto.SINAC.Properties.Resources.bin;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(95, 27);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // labelMensajeAdvertencia
            // 
            this.labelMensajeAdvertencia.AutoSize = true;
            this.labelMensajeAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensajeAdvertencia.Location = new System.Drawing.Point(65, 664);
            this.labelMensajeAdvertencia.Name = "labelMensajeAdvertencia";
            this.labelMensajeAdvertencia.Size = new System.Drawing.Size(208, 20);
            this.labelMensajeAdvertencia.TabIndex = 16;
            this.labelMensajeAdvertencia.Text = "Mensaje de advertencia";
            this.labelMensajeAdvertencia.Visible = false;
            // 
            // ptbFotografia
            // 
            this.ptbFotografia.Image = global::Proyecto.SINAC.Properties.Resources.camara;
            this.ptbFotografia.Location = new System.Drawing.Point(192, 258);
            this.ptbFotografia.Name = "ptbFotografia";
            this.ptbFotografia.Size = new System.Drawing.Size(247, 127);
            this.ptbFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbFotografia.TabIndex = 9;
            this.ptbFotografia.TabStop = false;
            this.ptbFotografia.Click += new System.EventHandler(this.ptbFotografia_Click);
            // 
            // AreaDeConservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.labelMensajeAdvertencia);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtTipoArea);
            this.Controls.Add(this.cmbGuardaParque);
            this.Controls.Add(this.dgvAreaConservacion);
            this.Controls.Add(this.txtSitioWeb);
            this.Controls.Add(this.ptbFotografia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "AreaDeConservacion";
            this.Size = new System.Drawing.Size(1477, 800);
            this.Load += new System.EventHandler(this.AreaDeConservacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaConservacion)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox ptbFotografia;
        private System.Windows.Forms.TextBox txtSitioWeb;
        private System.Windows.Forms.ComboBox cmbGuardaParque;
        private System.Windows.Forms.DataGridView dgvAreaConservacion;
        private System.Windows.Forms.TextBox txtTipoArea;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.Label labelMensajeAdvertencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroGuarda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoArea;
        private System.Windows.Forms.DataGridViewImageColumn Fotografia;
        private System.Windows.Forms.DataGridViewLinkColumn SitioWeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}
