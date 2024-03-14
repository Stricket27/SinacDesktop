
namespace Proyecto.SINAC.AdministradorGuarda
{
    partial class Disponibilidades
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
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.mtbHorarioFinal = new System.Windows.Forms.MaskedTextBox();
            this.mtbHorarioInicio = new System.Windows.Forms.MaskedTextBox();
            this.mudCantidadDenEntradas = new System.Windows.Forms.NumericUpDown();
            this.cmbAreaDeConservacion = new System.Windows.Forms.ComboBox();
            this.dgvDisponibilidad = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEntradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.labelMensajeAdvertencia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaReservacion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.mudCantidadDenEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidad)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(81, 399);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 18);
            this.label15.TabIndex = 23;
            this.label15.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(243, 394);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 24);
            this.txtPrecio.TabIndex = 22;
            // 
            // mtbHorarioFinal
            // 
            this.mtbHorarioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbHorarioFinal.Location = new System.Drawing.Point(243, 304);
            this.mtbHorarioFinal.Mask = "##:## LL";
            this.mtbHorarioFinal.Name = "mtbHorarioFinal";
            this.mtbHorarioFinal.Size = new System.Drawing.Size(88, 24);
            this.mtbHorarioFinal.TabIndex = 19;
            // 
            // mtbHorarioInicio
            // 
            this.mtbHorarioInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbHorarioInicio.Location = new System.Drawing.Point(243, 250);
            this.mtbHorarioInicio.Mask = "##:## LL";
            this.mtbHorarioInicio.Name = "mtbHorarioInicio";
            this.mtbHorarioInicio.Size = new System.Drawing.Size(88, 24);
            this.mtbHorarioInicio.TabIndex = 18;
            // 
            // mudCantidadDenEntradas
            // 
            this.mudCantidadDenEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mudCantidadDenEntradas.Location = new System.Drawing.Point(243, 349);
            this.mudCantidadDenEntradas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.mudCantidadDenEntradas.Name = "mudCantidadDenEntradas";
            this.mudCantidadDenEntradas.Size = new System.Drawing.Size(120, 24);
            this.mudCantidadDenEntradas.TabIndex = 17;
            // 
            // cmbAreaDeConservacion
            // 
            this.cmbAreaDeConservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreaDeConservacion.FormattingEnabled = true;
            this.cmbAreaDeConservacion.Location = new System.Drawing.Point(243, 160);
            this.cmbAreaDeConservacion.Name = "cmbAreaDeConservacion";
            this.cmbAreaDeConservacion.Size = new System.Drawing.Size(345, 26);
            this.cmbAreaDeConservacion.TabIndex = 14;
            // 
            // dgvDisponibilidad
            // 
            this.dgvDisponibilidad.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDisponibilidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibilidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NumeroArea,
            this.HorarioInicio,
            this.HoraFinal,
            this.CantidadEntradas,
            this.Precio,
            this.FechaDeReservacion});
            this.dgvDisponibilidad.Location = new System.Drawing.Point(623, 68);
            this.dgvDisponibilidad.Name = "dgvDisponibilidad";
            this.dgvDisponibilidad.RowHeadersWidth = 51;
            this.dgvDisponibilidad.RowTemplate.Height = 24;
            this.dgvDisponibilidad.Size = new System.Drawing.Size(899, 615);
            this.dgvDisponibilidad.TabIndex = 13;
            this.dgvDisponibilidad.SelectionChanged += new System.EventHandler(this.dgvDisponibilidad_SelectionChanged);
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
            // NumeroArea
            // 
            this.NumeroArea.DataPropertyName = "IDAreaConservacion";
            this.NumeroArea.HeaderText = "Número de area";
            this.NumeroArea.MinimumWidth = 6;
            this.NumeroArea.Name = "NumeroArea";
            this.NumeroArea.ReadOnly = true;
            this.NumeroArea.Width = 125;
            // 
            // HorarioInicio
            // 
            this.HorarioInicio.DataPropertyName = "HoraDeInicio";
            this.HorarioInicio.HeaderText = "Hora de inicio";
            this.HorarioInicio.MinimumWidth = 6;
            this.HorarioInicio.Name = "HorarioInicio";
            this.HorarioInicio.ReadOnly = true;
            this.HorarioInicio.Width = 125;
            // 
            // HoraFinal
            // 
            this.HoraFinal.DataPropertyName = "HoraFinal";
            this.HoraFinal.HeaderText = "Hora final";
            this.HoraFinal.MinimumWidth = 6;
            this.HoraFinal.Name = "HoraFinal";
            this.HoraFinal.ReadOnly = true;
            this.HoraFinal.Width = 125;
            // 
            // CantidadEntradas
            // 
            this.CantidadEntradas.DataPropertyName = "CantidadEntradas";
            this.CantidadEntradas.HeaderText = "Cantidad de entradas";
            this.CantidadEntradas.MinimumWidth = 6;
            this.CantidadEntradas.Name = "CantidadEntradas";
            this.CantidadEntradas.ReadOnly = true;
            this.CantidadEntradas.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // FechaDeReservacion
            // 
            this.FechaDeReservacion.DataPropertyName = "FechaDeReservacion";
            this.FechaDeReservacion.HeaderText = "Fecha de reservación";
            this.FechaDeReservacion.MinimumWidth = 6;
            this.FechaDeReservacion.Name = "FechaDeReservacion";
            this.FechaDeReservacion.ReadOnly = true;
            this.FechaDeReservacion.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(81, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cantidad de entradas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(81, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Hora final";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(81, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Hora de inicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(81, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Area de conservación";
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
            this.toolStrip1.Size = new System.Drawing.Size(1541, 31);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.Image = global::Proyecto.SINAC.Properties.Resources.add;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(95, 28);
            this.tsbAgregar.Text = "Agregar";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::Proyecto.SINAC.Properties.Resources.editar;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(78, 28);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::Proyecto.SINAC.Properties.Resources.bin;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(95, 28);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // labelMensajeAdvertencia
            // 
            this.labelMensajeAdvertencia.AutoSize = true;
            this.labelMensajeAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensajeAdvertencia.Location = new System.Drawing.Point(80, 738);
            this.labelMensajeAdvertencia.Name = "labelMensajeAdvertencia";
            this.labelMensajeAdvertencia.Size = new System.Drawing.Size(208, 20);
            this.labelMensajeAdvertencia.TabIndex = 24;
            this.labelMensajeAdvertencia.Text = "Mnesaje de advertencia";
            this.labelMensajeAdvertencia.Visible = false;
            this.labelMensajeAdvertencia.Click += new System.EventHandler(this.labelMensajeAdvertencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fecha de reservación";
            // 
            // dtpFechaReservacion
            // 
            this.dtpFechaReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReservacion.Location = new System.Drawing.Point(243, 208);
            this.dtpFechaReservacion.Name = "dtpFechaReservacion";
            this.dtpFechaReservacion.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaReservacion.TabIndex = 26;
            // 
            // Disponibilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dtpFechaReservacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMensajeAdvertencia);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.dgvDisponibilidad);
            this.Controls.Add(this.cmbAreaDeConservacion);
            this.Controls.Add(this.mtbHorarioFinal);
            this.Controls.Add(this.mtbHorarioInicio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mudCantidadDenEntradas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "Disponibilidades";
            this.Size = new System.Drawing.Size(1541, 935);
            this.Load += new System.EventHandler(this.Disponibilidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mudCantidadDenEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidad)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.MaskedTextBox mtbHorarioFinal;
        private System.Windows.Forms.MaskedTextBox mtbHorarioInicio;
        private System.Windows.Forms.NumericUpDown mudCantidadDenEntradas;
        private System.Windows.Forms.ComboBox cmbAreaDeConservacion;
        private System.Windows.Forms.DataGridView dgvDisponibilidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.Label labelMensajeAdvertencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeReservacion;
    }
}
