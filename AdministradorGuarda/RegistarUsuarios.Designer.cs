
namespace Proyecto.SINAC
{
    partial class RegistarUsuarios
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.mtbFechaDeNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConfirmarContrasenia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListaDeUsuarios = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabelCrearModificar = new System.Windows.Forms.LinkLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.linkLabelHabilitar = new System.Windows.Forms.LinkLabel();
            this.tsbRegistrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEstadoInactivo = new System.Windows.Forms.ToolStripButton();
            this.tsbEstadoActivo = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeUsuarios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Controls.Add(this.mtbFechaDeNacimiento);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.txtNacionalidad);
            this.panel2.Controls.Add(this.txtProfesion);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtCorreoElectronico);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtContrasenia);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtConfirmarContrasenia);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(48, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 469);
            this.panel2.TabIndex = 41;
            this.panel2.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(278, 24);
            this.label17.TabIndex = 33;
            this.label17.Text = "Ingrese los datos personales";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(7, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(278, 24);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(7, 97);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(278, 24);
            this.txtApellido.TabIndex = 1;
            // 
            // mtbFechaDeNacimiento
            // 
            this.mtbFechaDeNacimiento.Location = new System.Drawing.Point(7, 233);
            this.mtbFechaDeNacimiento.Mask = "##/##/####";
            this.mtbFechaDeNacimiento.Name = "mtbFechaDeNacimiento";
            this.mtbFechaDeNacimiento.Size = new System.Drawing.Size(278, 24);
            this.mtbFechaDeNacimiento.TabIndex = 32;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(7, 142);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(278, 24);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(7, 187);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(278, 24);
            this.txtNacionalidad.TabIndex = 3;
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(7, 277);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(278, 24);
            this.txtProfesion.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Confirmar contraseña";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(7, 322);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(278, 24);
            this.txtCorreoElectronico.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(7, 367);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(278, 24);
            this.txtContrasenia.TabIndex = 7;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Correo electrónico";
            // 
            // txtConfirmarContrasenia
            // 
            this.txtConfirmarContrasenia.Location = new System.Drawing.Point(7, 412);
            this.txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            this.txtConfirmarContrasenia.Size = new System.Drawing.Size(278, 24);
            this.txtConfirmarContrasenia.TabIndex = 9;
            this.txtConfirmarContrasenia.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Profesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nacionalidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Número de teléfono";
            // 
            // dgvListaDeUsuarios
            // 
            this.dgvListaDeUsuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListaDeUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaDeUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Nacionalidad,
            this.FechaDeNacimiento,
            this.Profesion,
            this.Correo,
            this.Contrasenia,
            this.Estado});
            this.dgvListaDeUsuarios.Location = new System.Drawing.Point(431, 48);
            this.dgvListaDeUsuarios.Name = "dgvListaDeUsuarios";
            this.dgvListaDeUsuarios.RowHeadersWidth = 51;
            this.dgvListaDeUsuarios.RowTemplate.Height = 24;
            this.dgvListaDeUsuarios.Size = new System.Drawing.Size(963, 551);
            this.dgvListaDeUsuarios.TabIndex = 42;
            this.dgvListaDeUsuarios.SelectionChanged += new System.EventHandler(this.dgvListaDeUsuarios_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ID";
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "Nacionalidad";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.MinimumWidth = 6;
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            this.Nacionalidad.Width = 125;
            // 
            // FechaDeNacimiento
            // 
            this.FechaDeNacimiento.DataPropertyName = "FechaDeNacimiento";
            this.FechaDeNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaDeNacimiento.MinimumWidth = 6;
            this.FechaDeNacimiento.Name = "FechaDeNacimiento";
            this.FechaDeNacimiento.ReadOnly = true;
            this.FechaDeNacimiento.Width = 125;
            // 
            // Profesion
            // 
            this.Profesion.DataPropertyName = "Profesion";
            this.Profesion.HeaderText = "Profesión";
            this.Profesion.MinimumWidth = 6;
            this.Profesion.Name = "Profesion";
            this.Profesion.ReadOnly = true;
            this.Profesion.Width = 125;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "CorreoElectronico";
            this.Correo.HeaderText = "Correo Electronico";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 125;
            // 
            // Contrasenia
            // 
            this.Contrasenia.DataPropertyName = "Contrasenia";
            this.Contrasenia.HeaderText = "Contraseña";
            this.Contrasenia.MinimumWidth = 6;
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.ReadOnly = true;
            this.Contrasenia.Visible = false;
            this.Contrasenia.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // linkLabelCrearModificar
            // 
            this.linkLabelCrearModificar.AutoSize = true;
            this.linkLabelCrearModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCrearModificar.Location = new System.Drawing.Point(45, 58);
            this.linkLabelCrearModificar.Name = "linkLabelCrearModificar";
            this.linkLabelCrearModificar.Size = new System.Drawing.Size(174, 18);
            this.linkLabelCrearModificar.TabIndex = 45;
            this.linkLabelCrearModificar.TabStop = true;
            this.linkLabelCrearModificar.Text = "Crear / Modificar Usuario";
            this.linkLabelCrearModificar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCrearModificar_LinkClicked);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRegistrar,
            this.tsbEditar,
            this.tsbEstadoInactivo,
            this.tsbEstadoActivo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1412, 27);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // linkLabelHabilitar
            // 
            this.linkLabelHabilitar.AutoSize = true;
            this.linkLabelHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHabilitar.Location = new System.Drawing.Point(231, 58);
            this.linkLabelHabilitar.Name = "linkLabelHabilitar";
            this.linkLabelHabilitar.Size = new System.Drawing.Size(119, 18);
            this.linkLabelHabilitar.TabIndex = 48;
            this.linkLabelHabilitar.TabStop = true;
            this.linkLabelHabilitar.Text = "Habilitar campos";
            this.linkLabelHabilitar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHabilitar_LinkClicked);
            // 
            // tsbRegistrar
            // 
            this.tsbRegistrar.Image = global::Proyecto.SINAC.Properties.Resources.add_user;
            this.tsbRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegistrar.Name = "tsbRegistrar";
            this.tsbRegistrar.Size = new System.Drawing.Size(92, 24);
            this.tsbRegistrar.Text = "Registrar";
            this.tsbRegistrar.Click += new System.EventHandler(this.tsbRegistrar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::Proyecto.SINAC.Properties.Resources.editar;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(72, 24);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEstadoInactivo
            // 
            this.tsbEstadoInactivo.Image = global::Proyecto.SINAC.Properties.Resources.eliminar;
            this.tsbEstadoInactivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEstadoInactivo.Name = "tsbEstadoInactivo";
            this.tsbEstadoInactivo.Size = new System.Drawing.Size(151, 24);
            this.tsbEstadoInactivo.Text = "Estado: INACTIVO";
            this.tsbEstadoInactivo.Click += new System.EventHandler(this.tsbEstadoInactivo_Click);
            // 
            // tsbEstadoActivo
            // 
            this.tsbEstadoActivo.Image = global::Proyecto.SINAC.Properties.Resources.comprobado;
            this.tsbEstadoActivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEstadoActivo.Name = "tsbEstadoActivo";
            this.tsbEstadoActivo.Size = new System.Drawing.Size(136, 24);
            this.tsbEstadoActivo.Text = "Estado: ACTIVO";
            this.tsbEstadoActivo.Click += new System.EventHandler(this.tsbEstadoActivo_Click);
            // 
            // RegistarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.linkLabelHabilitar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.linkLabelCrearModificar);
            this.Controls.Add(this.dgvListaDeUsuarios);
            this.Controls.Add(this.panel2);
            this.Name = "RegistarUsuarios";
            this.Size = new System.Drawing.Size(1412, 817);
            this.Load += new System.EventHandler(this.RegistarUsuarios_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeUsuarios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.MaskedTextBox mtbFechaDeNacimiento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConfirmarContrasenia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListaDeUsuarios;
        private System.Windows.Forms.LinkLabel linkLabelCrearModificar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRegistrar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEstadoInactivo;
        private System.Windows.Forms.ToolStripButton tsbEstadoActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.LinkLabel linkLabelHabilitar;
    }
}
