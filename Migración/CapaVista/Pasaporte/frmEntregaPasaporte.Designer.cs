
namespace CapaVista.Pasaporte
{
    partial class frmEntregaPasaporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregaPasaporte));
            this.LblPasaporte = new System.Windows.Forms.Label();
            this.TxtIdPass = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblFechaCre = new System.Windows.Forms.Label();
            this.DtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.BtnLista = new System.Windows.Forms.Button();
            this.LblNumLib = new System.Windows.Forms.Label();
            this.TxtNumLibreta = new System.Windows.Forms.TextBox();
            this.LblTipoPass = new System.Windows.Forms.Label();
            this.CmbTipoPass = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GbxDatos = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.GbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPasaporte
            // 
            this.LblPasaporte.AutoSize = true;
            this.LblPasaporte.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasaporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPasaporte.Location = new System.Drawing.Point(22, 48);
            this.LblPasaporte.Name = "LblPasaporte";
            this.LblPasaporte.Size = new System.Drawing.Size(256, 22);
            this.LblPasaporte.TabIndex = 129;
            this.LblPasaporte.Text = "Ingrese el Id del Pasaporte";
            // 
            // TxtIdPass
            // 
            this.TxtIdPass.Location = new System.Drawing.Point(303, 47);
            this.TxtIdPass.Multiline = true;
            this.TxtIdPass.Name = "TxtIdPass";
            this.TxtIdPass.Size = new System.Drawing.Size(204, 28);
            this.TxtIdPass.TabIndex = 134;
            this.TxtIdPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FuncNumero);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.BtnIngresar.Enabled = false;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIngresar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIngresar.Location = new System.Drawing.Point(614, 346);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(190, 61);
            this.BtnIngresar.TabIndex = 135;
            this.BtnIngresar.Text = "Ingresar Datos";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblFechaCre
            // 
            this.LblFechaCre.AutoSize = true;
            this.LblFechaCre.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaCre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFechaCre.Location = new System.Drawing.Point(6, 164);
            this.LblFechaCre.Name = "LblFechaCre";
            this.LblFechaCre.Size = new System.Drawing.Size(267, 22);
            this.LblFechaCre.TabIndex = 136;
            this.LblFechaCre.Text = "Fecha de Entrega Pasaporte";
            // 
            // DtpEntrega
            // 
            this.DtpEntrega.CalendarFont = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEntrega.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtpEntrega.Location = new System.Drawing.Point(298, 164);
            this.DtpEntrega.Name = "DtpEntrega";
            this.DtpEntrega.Size = new System.Drawing.Size(456, 31);
            this.DtpEntrega.TabIndex = 137;
            // 
            // BtnLista
            // 
            this.BtnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.BtnLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLista.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLista.ForeColor = System.Drawing.Color.White;
            this.BtnLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLista.Location = new System.Drawing.Point(19, 346);
            this.BtnLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLista.Name = "BtnLista";
            this.BtnLista.Size = new System.Drawing.Size(190, 61);
            this.BtnLista.TabIndex = 138;
            this.BtnLista.Text = "Lista Pasaportes";
            this.BtnLista.UseVisualStyleBackColor = false;
            this.BtnLista.Click += new System.EventHandler(this.BtnLista_Click);
            // 
            // LblNumLib
            // 
            this.LblNumLib.AutoSize = true;
            this.LblNumLib.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumLib.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNumLib.Location = new System.Drawing.Point(6, 53);
            this.LblNumLib.Name = "LblNumLib";
            this.LblNumLib.Size = new System.Drawing.Size(187, 22);
            this.LblNumLib.TabIndex = 141;
            this.LblNumLib.Text = "Número de Libreta:";
            // 
            // TxtNumLibreta
            // 
            this.TxtNumLibreta.Enabled = false;
            this.TxtNumLibreta.Location = new System.Drawing.Point(303, 44);
            this.TxtNumLibreta.Multiline = true;
            this.TxtNumLibreta.Name = "TxtNumLibreta";
            this.TxtNumLibreta.Size = new System.Drawing.Size(219, 31);
            this.TxtNumLibreta.TabIndex = 142;
            // 
            // LblTipoPass
            // 
            this.LblTipoPass.AutoSize = true;
            this.LblTipoPass.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTipoPass.Location = new System.Drawing.Point(6, 106);
            this.LblTipoPass.Name = "LblTipoPass";
            this.LblTipoPass.Size = new System.Drawing.Size(176, 22);
            this.LblTipoPass.TabIndex = 139;
            this.LblTipoPass.Text = "Tipo de Pasaporte";
            // 
            // CmbTipoPass
            // 
            this.CmbTipoPass.Enabled = false;
            this.CmbTipoPass.FormattingEnabled = true;
            this.CmbTipoPass.Location = new System.Drawing.Point(303, 106);
            this.CmbTipoPass.Name = "CmbTipoPass";
            this.CmbTipoPass.Size = new System.Drawing.Size(219, 30);
            this.CmbTipoPass.TabIndex = 140;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(553, 36);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(130, 48);
            this.BtnBuscar.TabIndex = 143;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GbxDatos
            // 
            this.GbxDatos.Controls.Add(this.LblTipoPass);
            this.GbxDatos.Controls.Add(this.CmbTipoPass);
            this.GbxDatos.Controls.Add(this.LblNumLib);
            this.GbxDatos.Controls.Add(this.TxtNumLibreta);
            this.GbxDatos.Controls.Add(this.LblFechaCre);
            this.GbxDatos.Controls.Add(this.DtpEntrega);
            this.GbxDatos.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GbxDatos.Location = new System.Drawing.Point(16, 98);
            this.GbxDatos.Name = "GbxDatos";
            this.GbxDatos.Size = new System.Drawing.Size(788, 220);
            this.GbxDatos.TabIndex = 144;
            this.GbxDatos.TabStop = false;
            this.GbxDatos.Text = "Datos Pasaporte";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(732, 11);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(72, 72);
            this.btnAyuda.TabIndex = 145;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // frmEntregaPasaporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(825, 430);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.GbxDatos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnLista);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtIdPass);
            this.Controls.Add(this.LblPasaporte);
            this.Name = "frmEntregaPasaporte";
            this.Text = "frmEntregaPasaporte";
            this.Load += new System.EventHandler(this.frmEntregaPasaporte_Load);
            this.GbxDatos.ResumeLayout(false);
            this.GbxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPasaporte;
        private System.Windows.Forms.TextBox TxtIdPass;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblFechaCre;
        private System.Windows.Forms.DateTimePicker DtpEntrega;
        private System.Windows.Forms.Button BtnLista;
        private System.Windows.Forms.Label LblNumLib;
        private System.Windows.Forms.TextBox TxtNumLibreta;
        private System.Windows.Forms.Label LblTipoPass;
        private System.Windows.Forms.ComboBox CmbTipoPass;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox GbxDatos;
        private System.Windows.Forms.Button btnAyuda;
    }
}