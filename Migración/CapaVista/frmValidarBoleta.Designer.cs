
namespace CapaVista
{
    partial class frmValidarBoleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidarBoleta));
            this.txtBoleta = new System.Windows.Forms.TextBox();
            this.lblBoleta = new System.Windows.Forms.Label();
            this.lblRecibo = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnValidarBoleta = new System.Windows.Forms.Button();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.gbBoleta = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbBoleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoleta
            // 
            this.txtBoleta.Location = new System.Drawing.Point(23, 106);
            this.txtBoleta.Multiline = true;
            this.txtBoleta.Name = "txtBoleta";
            this.txtBoleta.Size = new System.Drawing.Size(389, 31);
            this.txtBoleta.TabIndex = 85;
            this.txtBoleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoleta_KeyPress);
            // 
            // lblBoleta
            // 
            this.lblBoleta.AutoSize = true;
            this.lblBoleta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoleta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBoleta.Location = new System.Drawing.Point(19, 64);
            this.lblBoleta.Name = "lblBoleta";
            this.lblBoleta.Size = new System.Drawing.Size(103, 22);
            this.lblBoleta.TabIndex = 84;
            this.lblBoleta.Text = "No. Boleta\r\n";
            // 
            // lblRecibo
            // 
            this.lblRecibo.AutoSize = true;
            this.lblRecibo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecibo.Location = new System.Drawing.Point(19, 158);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(109, 22);
            this.lblRecibo.TabIndex = 83;
            this.lblRecibo.Text = "No. Recibo\r\n";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(526, 48);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(72, 72);
            this.btnAyuda.TabIndex = 82;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnValidarBoleta
            // 
            this.btnValidarBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnValidarBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidarBoleta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarBoleta.ForeColor = System.Drawing.Color.White;
            this.btnValidarBoleta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarBoleta.Location = new System.Drawing.Point(23, 258);
            this.btnValidarBoleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidarBoleta.Name = "btnValidarBoleta";
            this.btnValidarBoleta.Size = new System.Drawing.Size(190, 61);
            this.btnValidarBoleta.TabIndex = 81;
            this.btnValidarBoleta.Text = "Validar Boleta";
            this.btnValidarBoleta.UseVisualStyleBackColor = false;
            this.btnValidarBoleta.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(23, 206);
            this.txtRecibo.Multiline = true;
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(389, 31);
            this.txtRecibo.TabIndex = 87;
            this.txtRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecibo_KeyPress);
            // 
            // gbBoleta
            // 
            this.gbBoleta.Controls.Add(this.btnCancelar);
            this.gbBoleta.Controls.Add(this.txtRecibo);
            this.gbBoleta.Controls.Add(this.txtBoleta);
            this.gbBoleta.Controls.Add(this.lblBoleta);
            this.gbBoleta.Controls.Add(this.lblRecibo);
            this.gbBoleta.Controls.Add(this.btnValidarBoleta);
            this.gbBoleta.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBoleta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbBoleta.Location = new System.Drawing.Point(12, 34);
            this.gbBoleta.Name = "gbBoleta";
            this.gbBoleta.Size = new System.Drawing.Size(470, 341);
            this.gbBoleta.TabIndex = 88;
            this.gbBoleta.TabStop = false;
            this.gbBoleta.Text = "Ingrese los datos de la boleta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(222, 258);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 61);
            this.btnCancelar.TabIndex = 88;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmValidarBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(622, 408);
            this.Controls.Add(this.gbBoleta);
            this.Controls.Add(this.btnAyuda);
            this.Name = "frmValidarBoleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmValidarBoleta";
            this.gbBoleta.ResumeLayout(false);
            this.gbBoleta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoleta;
        private System.Windows.Forms.Label lblBoleta;
        private System.Windows.Forms.Label lblRecibo;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnValidarBoleta;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.GroupBox gbBoleta;
        private System.Windows.Forms.Button btnCancelar;
    }
}