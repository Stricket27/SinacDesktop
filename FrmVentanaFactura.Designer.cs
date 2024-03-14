
namespace Proyecto.SINAC
{
    partial class FrmVentanaFactura
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
            this.rtbFactura = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbFactura
            // 
            this.rtbFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFactura.Location = new System.Drawing.Point(0, 0);
            this.rtbFactura.Name = "rtbFactura";
            this.rtbFactura.Size = new System.Drawing.Size(800, 450);
            this.rtbFactura.TabIndex = 0;
            this.rtbFactura.Text = "";
            // 
            // FrmVentanaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbFactura);
            this.Name = "FrmVentanaFactura";
            this.Text = "FrmVentanaFactura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFactura;
    }
}