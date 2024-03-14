
namespace Proyecto.SINAC
{
    partial class frmVentanPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnIniciarSeccion = new System.Windows.Forms.Button();
            this.LinkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.LinkRecuperarContrasenia = new System.Windows.Forms.LinkLabel();
            this.labelMensajeError = new System.Windows.Forms.Label();
            this.rdbEspanol = new System.Windows.Forms.RadioButton();
            this.rdbEnglish = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar correo electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar contraseña";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(386, 133);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(246, 17);
            this.txtCorreoElectronico.TabIndex = 3;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(386, 202);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(242, 17);
            this.txtContrasenia.TabIndex = 4;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // btnIniciarSeccion
            // 
            this.btnIniciarSeccion.BackColor = System.Drawing.SystemColors.Window;
            this.btnIniciarSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSeccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciarSeccion.Location = new System.Drawing.Point(449, 243);
            this.btnIniciarSeccion.Name = "btnIniciarSeccion";
            this.btnIniciarSeccion.Size = new System.Drawing.Size(153, 40);
            this.btnIniciarSeccion.TabIndex = 5;
            this.btnIniciarSeccion.Text = "Iniciar Sección";
            this.btnIniciarSeccion.UseVisualStyleBackColor = false;
            this.btnIniciarSeccion.Click += new System.EventHandler(this.btnIniciarSeccion_Click);
            // 
            // LinkRegistrarse
            // 
            this.LinkRegistrarse.AutoSize = true;
            this.LinkRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkRegistrarse.Location = new System.Drawing.Point(329, 305);
            this.LinkRegistrarse.Name = "LinkRegistrarse";
            this.LinkRegistrarse.Size = new System.Drawing.Size(306, 18);
            this.LinkRegistrarse.TabIndex = 6;
            this.LinkRegistrarse.TabStop = true;
            this.LinkRegistrarse.Text = "No tienes una cuenta propia? Registrese aqui";
            this.LinkRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegistrarse_LinkClicked);
            // 
            // LinkRecuperarContrasenia
            // 
            this.LinkRecuperarContrasenia.AutoSize = true;
            this.LinkRecuperarContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkRecuperarContrasenia.Location = new System.Drawing.Point(340, 401);
            this.LinkRecuperarContrasenia.Name = "LinkRecuperarContrasenia";
            this.LinkRecuperarContrasenia.Size = new System.Drawing.Size(260, 18);
            this.LinkRecuperarContrasenia.TabIndex = 7;
            this.LinkRecuperarContrasenia.TabStop = true;
            this.LinkRecuperarContrasenia.Text = "A olvidado la contraseña? Ingrese aqui";
            this.LinkRecuperarContrasenia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRecuperarContrasenia_LinkClicked);
            // 
            // labelMensajeError
            // 
            this.labelMensajeError.AutoSize = true;
            this.labelMensajeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensajeError.Location = new System.Drawing.Point(275, 342);
            this.labelMensajeError.Name = "labelMensajeError";
            this.labelMensajeError.Size = new System.Drawing.Size(133, 17);
            this.labelMensajeError.TabIndex = 8;
            this.labelMensajeError.Text = "Mensaje de Error";
            this.labelMensajeError.Visible = false;
            this.labelMensajeError.Click += new System.EventHandler(this.labelMensajeError_Click);
            // 
            // rdbEspanol
            // 
            this.rdbEspanol.AutoSize = true;
            this.rdbEspanol.Checked = true;
            this.rdbEspanol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEspanol.Location = new System.Drawing.Point(362, 450);
            this.rdbEspanol.Name = "rdbEspanol";
            this.rdbEspanol.Size = new System.Drawing.Size(83, 22);
            this.rdbEspanol.TabIndex = 9;
            this.rdbEspanol.TabStop = true;
            this.rdbEspanol.Text = "Español";
            this.rdbEspanol.UseVisualStyleBackColor = true;
            this.rdbEspanol.CheckedChanged += new System.EventHandler(this.rdbEspanol_CheckedChanged);
            // 
            // rdbEnglish
            // 
            this.rdbEnglish.AutoSize = true;
            this.rdbEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnglish.Location = new System.Drawing.Point(525, 450);
            this.rdbEnglish.Name = "rdbEnglish";
            this.rdbEnglish.Size = new System.Drawing.Size(77, 22);
            this.rdbEnglish.TabIndex = 10;
            this.rdbEnglish.TabStop = true;
            this.rdbEnglish.Text = "English";
            this.rdbEnglish.UseVisualStyleBackColor = true;
            this.rdbEnglish.CheckedChanged += new System.EventHandler(this.rdbEnglish_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "------------------------------------------------------------";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Proyecto.SINAC.Properties.Resources.Logo_de_SINAC1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 548);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "------------------------------------------------------------";
            // 
            // frmVentanPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(773, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdbEnglish);
            this.Controls.Add(this.rdbEspanol);
            this.Controls.Add(this.labelMensajeError);
            this.Controls.Add(this.LinkRecuperarContrasenia);
            this.Controls.Add(this.LinkRegistrarse);
            this.Controls.Add(this.btnIniciarSeccion);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmVentanPrincipal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmVentanPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnIniciarSeccion;
        private System.Windows.Forms.LinkLabel LinkRegistrarse;
        private System.Windows.Forms.LinkLabel LinkRecuperarContrasenia;
        private System.Windows.Forms.Label labelMensajeError;
        private System.Windows.Forms.RadioButton rdbEspanol;
        private System.Windows.Forms.RadioButton rdbEnglish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

